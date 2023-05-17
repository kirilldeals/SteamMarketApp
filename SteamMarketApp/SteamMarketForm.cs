using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SteamMarketApp.Api;
using SteamMarketApp.Auth;
using SteamMarketApp.Helpers;
using SteamMarketApp.Models;
using SteamMarketApp.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SteamMarketApp
{
    public partial class SteamMarketForm : Form
    {
        private const string DateFormat = "MMM dd yyyy HH: z";

        private readonly Dictionary<int, char> _apps;
        private readonly SteamLoginForm _loginForm;
        private readonly SteamAccount _steamAccount;
        private readonly MongoContext _mongoContext;
        private readonly SteamItemsService<MarketItem> _marketItemsService;
        private readonly SteamItemsService<InventoryItem> _inventoryItemsService;

        private CancellationTokenSource? _cts;

        private long _marketCount;
        public long MarketCount
        {
            get { return _marketCount; }
            set
            {
                if (value != _marketCount)
                {
                    _marketCount = value;
                    if (lblMarketCount.IsHandleCreated)
                    {
                        BeginInvoke(() =>
                        {
                            lblMarketCount.Text = _marketCount.ToString();
                        });
                    }
                    else
                        lblMarketCount.Text = _marketCount.ToString();
                }
            }
        }

        private long _inventoryCount;
        public long InventoryCount
        {
            get { return _inventoryCount; }
            set
            {
                if (value != _inventoryCount)
                {
                    _inventoryCount = value;
                    lblInventoryCount.Text = _inventoryCount.ToString();
                }
            }
        }

        public SteamMarketForm(SteamLoginForm loginForm, SteamAccount account)
        {
            InitializeComponent();
            this.FormClosed += (sender, e) =>
            {
                Application.Exit();
            };

            Dictionary<string, string> filters = new()
            {
                { "Growth Rate", "FindByGrowth" },
                { "Price", "FindByPrice" },
            };
            cboFilterBy.DataSource = new BindingSource(filters, null);
            cboFilterBy.DisplayMember = "Key";
            cboFilterBy.ValueMember = "Value";
            cboFilterBy.SelectedIndex = 0;

            _apps = new Dictionary<int, char>() {
                { 753, '6'},
                { 730, '2'},
                { 570, '2'},
                { 578080, '2'},
                { 252490, '1'},
                { 440, '2'},
            };
            _loginForm = loginForm;
            _steamAccount = account;
            _mongoContext = new MongoContext();
            _marketItemsService = new SteamItemsService<MarketItem>(_mongoContext.Database, "market_items");
            _inventoryItemsService = new SteamItemsService<InventoryItem>(_mongoContext.Database, "inventory_items_" + account.SteamID);

            MarketCount = _marketItemsService.Count();
            InventoryCount = _inventoryItemsService.Count();
        }

        private void CreatePriceChartsFromMarket(object sender, EventArgs e)
        {
            CreatePriceCharts(_marketItemsService);
        }

        private void CreatePriceChartsFromInventory(object sender, EventArgs e)
        {
            CreatePriceCharts(_inventoryItemsService);
        }

        private void CreatePriceCharts<TSteamItem>(SteamItemsService<TSteamItem> itemsService) where TSteamItem : ISteamItem, new()
        {
            int chartCount = (int)chartCountNumericUpDown.Value;

            tlpPriceCharts.Controls.Clear();
            tlpPriceCharts.AutoScroll = false;

            tlpPriceCharts.RowCount = (int)chartCountNumericUpDown.Value + 1;
            tlpPriceCharts.ColumnCount = 2;
            tlpPriceCharts.RowStyles.Clear();

            Type type = itemsService.GetType();
            MethodInfo findDataMethod = type.GetMethod((string)cboFilterBy.SelectedValue);
            var decreaseItems = (List<TSteamItem>)findDataMethod.Invoke(itemsService, new object[] { chartCount, false });
            var increaseItems = (List<TSteamItem>)findDataMethod.Invoke(itemsService, new object[] { chartCount, true });
            #region Draw price history charts
            for (int i = 0; i < decreaseItems.Count; i++)
            {
                tlpPriceCharts.RowStyles.Add(new RowStyle(SizeType.Absolute, 250));
                int col = 0;
                foreach (var items in new[] { decreaseItems, increaseItems })
                {
                    TableLayoutPanel nestedTableLayoutPanel = new TableLayoutPanel();
                    nestedTableLayoutPanel.ColumnCount = 1;
                    nestedTableLayoutPanel.RowCount = 2;
                    nestedTableLayoutPanel.Dock = DockStyle.Fill;
                    nestedTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    nestedTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

                    LinkLabel itemLink = new LinkLabel();
                    itemLink.Text = items[i].Name;
                    var url = $"https://steamcommunity.com/market/listings/{items[i].Appid}/{items[i].Name}";
                    itemLink.LinkClicked += (sender, e) => System.Diagnostics.Process.Start("explorer.exe", url);
                    itemLink.AutoSize = true;
                    itemLink.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
                    itemLink.LinkColor = Color.FromArgb(220, 230, 240);
                    itemLink.Location = new Point(0, 0);
                    nestedTableLayoutPanel.Controls.Add(itemLink, 0, 0);

                    Chart chart = new Chart();
                    chart.Dock = DockStyle.Bottom;
                    chart.BackColor = Color.FromArgb(40, 45, 55);

                    ChartArea chartArea = new ChartArea();
                    chartArea.BackColor = Color.FromArgb(20, 25, 35);
                    chartArea.AxisX.LabelStyle.ForeColor = Color.FromArgb(220, 230, 240);
                    chartArea.AxisY.LabelStyle.ForeColor = Color.FromArgb(220, 230, 240);
                    chartArea.AxisY.Minimum = (int)items[i].Prices.Values.Min();
                    chart.ChartAreas.Add(chartArea);

                    Series series = new Series("Prices");
                    series.ChartType = SeriesChartType.Line;
                    series.BorderWidth = 2;
                    series.Color = Color.FromArgb(100, 140, 60);
                    chart.Series.Add(series);

                    chart.DataSource = items[i].Prices.Values;
                    chart.Series[0].Points.DataBindXY(items[i].Prices.Keys, items[i].Prices.Values);

                    chart.Location = new Point(0, itemLink.Bottom);
                    nestedTableLayoutPanel.Controls.Add(chart, 0, 1);

                    tlpPriceCharts.Controls.Add(nestedTableLayoutPanel, col, i);
                    col++;
                }
            }
            #endregion
            tlpPriceCharts.AutoScroll = true;
        }


        private async void ContinueGetItemsFromMarket(object sender, EventArgs e)
        {
            await GetItemsFromMarket(MarketCount);
        }

        private async void RefreshAllItemsFromMarket(object sender, EventArgs e)
        {
            await GetItemsFromMarket();
        }

        private async Task GetItemsFromMarket(long offset = 0)
        {
            btnMarketRefreshAll.Enabled = false;
            btnMarketGet.Enabled = false;

            _cts = new CancellationTokenSource();
            var token = _cts.Token;
            btnStopMarket.Visible = true;

            if (offset == 0)
            {
                await _marketItemsService.ClearAllAsync();
                MarketCount = 0;
            }

            List<Task> tasks = new List<Task>();
            var numberOfThreads = 4;

            for (int threadIndex = 0; threadIndex < numberOfThreads; threadIndex++)
            {
                long innerOffset = offset + threadIndex * 100;

                Task task = Task.Run(async () =>
                {
                    while (!token.IsCancellationRequested)
                    {
                        var result = await SteamWebRequest.GetAsync(_steamAccount.SteamLoginSecure, "/market/search/render", $"norender=1&start={innerOffset}&count=100");
                        if (await CheckForEmptyResponse(result, lblMarketTooManyRequests, token))
                            continue;
                        var steamItems = JsonConvert.DeserializeObject<MarketItems>(result).Collection;
                        await SaveItems(_marketItemsService, steamItems, () => MarketCount++, lblMarketTooManyRequests, token);
                        innerOffset += numberOfThreads * 100;
                    }
                }, 
                token);

                tasks.Add(task);
            }

            await Task.WhenAll(tasks);

            MarketCount = _marketItemsService.Count();
            btnMarketRefreshAll.Enabled = true;
            btnMarketGet.Enabled = true;
        }

        private async void RefreshAllItemsFromInventory(object sender, EventArgs e)
        {
            btnInventoryRefreshAll.Enabled = false;

            var cts = new CancellationTokenSource();
            var token = cts.Token;

            await _inventoryItemsService.ClearAllAsync();
            InventoryCount = 0;

            foreach (var app in _apps)
            {
                var offset = "";
                while (true)
                {
                    var result = await SteamWebRequest.GetAsync(_steamAccount.SteamLoginSecure, $"/inventory/{_steamAccount.SteamID}/{app.Key}/{app.Value}", $"start_assetid={offset}&count=100");
                    if (await CheckForEmptyResponse(result, lblInventoryTooManyRequests, token))
                        continue;
                    if (!result.StartsWith("{\"error\"") && !result.StartsWith("{\"total_inventory_count\""))
                    {
                        var allItems = JsonConvert.DeserializeObject<InventoryItems>(result).Collection;
                        var steamItems = allItems.Where(x => x.Marketable == true);
                        await SaveItems(_inventoryItemsService, steamItems, () => InventoryCount++, lblInventoryTooManyRequests, token);
                        if (allItems.Count() < 100)
                            break;

                        JObject json = JObject.Parse(result);
                        JArray assets = (JArray)json["assets"];
                        JToken lastAsset = assets.LastOrDefault();
                        offset = lastAsset["assetid"].ToString();
                    }
                    else
                        break;
                }
            }

            InventoryCount = _inventoryItemsService.Count();
            btnInventoryRefreshAll.Enabled = true;
        }

        private async Task SaveItems<TSteamItem>(SteamItemsService<TSteamItem> itemsService, IEnumerable<TSteamItem> steamItems, Action countIncrement, Label label, CancellationToken token) 
            where TSteamItem : ISteamItem, new()
        {
            var tasks = steamItems.Select(async item =>
            {
                await GetPriceHistory(item, label, token);
                if (item.Prices.Any())
                {
                    await itemsService.CreateAsync(item);
                    countIncrement();
                }
            });
            await Task.WhenAll(tasks);
        }

        private async Task GetPriceHistory(ISteamItem item, Label label, CancellationToken token)
        {
            while (true)
            {
                var result = await SteamWebRequest.GetAsync(_steamAccount.SteamLoginSecure, "/market/pricehistory", $"appid={item.Appid}&market_hash_name={HttpUtility.UrlEncode(item.Name)}");
                if (await CheckForEmptyResponse(result, label, token))
                    continue;
                JObject json = JsonConvert.DeserializeObject<JObject>(result);
                JArray resultsArray = (JArray)json["prices"];

                var dateBoundary = DateTime.Now.AddDays(-30);
                item.Prices = resultsArray
                    .Select(x => new KeyValuePair<DateTime, double>(DateTime.ParseExact((string)x[0], DateFormat, CultureInfo.InvariantCulture), (double)x[1]))
                    .OrderBy(x => x.Key)
                    .SkipWhile(x => x.Key < dateBoundary)
                    .ToDictionary(x => x.Key, x => x.Value);
                if (item.Prices.Any())
                {
                    item.GrowthRate = GrowthRateCalculator.Calculate(item.Prices.Values);
                }
                break;
            }
        }

        private async Task<bool> CheckForEmptyResponse(string result, Label label, CancellationToken token)
        {
            if (string.IsNullOrEmpty(result))
            {
                BeginInvoke(() =>
                {
                    label.Visible = true;
                });
                if (await Task.Run(() => token.WaitHandle.WaitOne(TimeSpan.FromMinutes(10))))
                {
                    BeginInvoke(() =>
                    {
                        label.Visible = false;
                    });
                    return true;
                }
            }
            return false;
        }

        private void StopMarketAPICalls(object sender, EventArgs e)
        {
            _cts?.Cancel();
            lblMarketTooManyRequests.Visible = false;
            btnStopMarket.Visible = false;
        }

        private void Logout(object sender, EventArgs e)
        {
            this.Dispose();
            _loginForm.Show();
        }
    }
}

# SteamMarketApp

### Introduction
The application is designed to retrieve data from [Steam Community Market](https://steamcommunity.com/market/) using the internal Steam WebAPI, allowing users to track the dynamics of item prices.

### Requirements
* .NET 7.0
* MongoDB Server 6.0

### Usage
1) Login to Steam Account (run browser in the background or explicitly):\
![login_v2](https://github.com/kirilldeals/SteamMarketApp/assets/124831993/1d4a16eb-62ef-42cb-ba11-4092e3029e6f)
2) Pass 2-factor authentication (if required):\
![login2factor_v2](https://github.com/kirilldeals/SteamMarketApp/assets/124831993/54bd37dd-a335-4aa2-9a35-fd437164c329)
3) Now you can retrieve history prices from steam market or your inventory:\
![main_v2](https://github.com/kirilldeals/SteamMarketApp/assets/124831993/26d7413f-e1df-4f7c-ae22-e3c6d5a9407c)

#### Buttons
* **Log Out**: Log out from current steam session
* **Get price histories from market**: Continue to retrieve price histories from market without deleting previous data
* **Refresh all (market)**: Delete all saved data about items from market and start retrieving data again
* **Refresh all (inventory)**: Delete all saved data about items from logged user's inventory and start retrieving data again
* **From market**: Show selected count of price charts from market
* **From inventory**: Show selected count of price charts from logged user's inventory

# SteamMarketApp

### Introduction
The application is designed to retrieve data from [Steam Community Market](https://steamcommunity.com/market/) using the internal Steam WebAPI, allowing users to track the dynamics of item prices.

### Requirements
* .NET 7.0
* MongoDB Server 6.0

### Usage
1) Login to Steam Account:\
![login](https://user-images.githubusercontent.com/124831993/231579839-6303d03f-c030-42e8-8084-b282a5204a28.PNG)
2) Pass 2-factor authentication (if required):\
![login2factor](https://user-images.githubusercontent.com/124831993/231579916-3bd7822f-58cc-44b6-832f-65394b841fd2.PNG)
3) Now you can retrieve history prices from steam market or your inventory:\
![main](https://user-images.githubusercontent.com/124831993/231580104-081d5a64-192f-4207-8744-f11f8c91a390.PNG)

#### Buttons
* **Log Out**: Log out from current steam session
* **Get price histories from market**: Continue to retrieve price histories from market without deleting previous data
* **Refresh all (market)**: Delete all saved data about items from market and start retrieving data again
* **Refresh all (inventory)**: Delete all saved data about items from logged user's inventory and start retrieving data again
* **From market**: Show selected count of price charts from market
* **From inventory**: Show selected count of price charts from logged user's inventory

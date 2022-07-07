# Ajuna.SDK.SubscriptionDemo 

This project was created in order to showcase the use of [Ajuna.SDK](https://github.com/ajuna-network/Ajuna.SDK), a .NET toolchain featuring .NET framework extensions and code generation utilities to build substrate storage services and clients quickly.

The project behind Ajuna.SDK is [Ajuna Network](https://ajuna.io/) and the flagship game [DOTMog](https://dotmog.com/), backed by the Swiss company [BloGa Tech AG](admin@bloga.tech).

## This Demo's Focus

This demo project focuses mainly on the implementation of the storage change subscription functionality, allowing the SDK's users to subscribe and get notified about storage changes on the Ajuna node. 

## Important
This project as well as the [Ajuna.SDK](https://github.com/ajuna-network/Ajuna.SDK) are under heavy development, and things may change quickly. 

## Getting Started

### Project Structure

The project structure is as follows:

```txt
.
├─── Ajuna.SDK.SubscriptionDemo.NetApi
├─── Ajuna.SDK.SubscriptionDemo.RestClient 
├─── Ajuna.SDK.SubscriptionDemo.RestClient.Mockup
├─── Ajuna.SDK.SubscriptionDemo.RestClient.Test
├─── Ajuna.SDK.SubscriptionDemo.RestService
├─── Ajuna.SDK.SubscriptionDemo.Console
```
All projects apart from `Ajuna.SDK.SubscriptionDemo.Console` have been generated by Ajuna.SDK.

- `Ajuna.SDK.SubscriptionDemo.RestService` is the generated Service Layer on top of Ajuna Node. It exposes a Rest Api and a Websocket for the Storage Change Notifications.
- `Ajuna.SDK.SubscriptionDemo.RestClient` is the Rest Client for calling the RestService.
- `Ajuna.SDK.SubscriptionDemo.Console` contains the storage subscription logic of this demo project. 


### Prerequisites
In order to run this project, you will need:
- A [Substrate node running locally](https://github.com/ajuna-network/Ajuna).
- A running instance of both the `Ajuna.SDK.SubscriptionDemo.RestService` and the `Ajuna.SDK.SubscriptionDemo.Console` projects.

### Endpoints
The Rest Service exposes two endpoints with the following Urls:
- Rest API: http://localhost:61752/swagger/index.html
- WebSocket: http://localhost:61752/ws

## Community

[![Discord Banner 1](https://discordapp.com/api/guilds/849331368558198803/widget.png?style=banner2)](https://discord.gg/cE72GYcFgY)

[![Discord Banner 2](https://discordapp.com/api/guilds/447132563924844544/widget.png?style=banner2)](https://discord.gg/GXYmNWtPzQ)


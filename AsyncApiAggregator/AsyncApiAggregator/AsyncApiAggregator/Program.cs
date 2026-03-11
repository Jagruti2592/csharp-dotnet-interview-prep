// See https://aka.ms/new-console-template for more information
using AsyncApiAggregator.Application;
using System.Security.Authentication.ExtendedProtection;
using AsyncApiAggregator.Services;
using Microsoft.Extensions.DependencyInjection;


Console.WriteLine("Hello, World!");

var services = new  ServiceCollection();

services.AddSingleton<UserService>();
services.AddSingleton<OrderService>();
services.AddSingleton<RecommendationService>();
services.AddSingleton<UserProfileAggregatorService>();
services.AddSingleton<DemoRunner>();

var serviceProvider = services.BuildServiceProvider();

var demo = serviceProvider.GetService<DemoRunner>();
await demo.RunAsync();
﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ModsDude.WPF.StartupHelpers;
using ModsDude.WPF.ViewModels;
using ModsDude.WPF.ViewModels.Components;
using ModsDude.WPF.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ModsDude.WPF;
public partial class App : Application
{
    public static IHost? AppHost { get; private set; }


    public App()
    {
        AppHost = Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddSingleton<MainWindowViewModel>();
                services.AddSingleton<MainWindow>();
            })
            .Build();
    }


    protected override async void OnStartup(StartupEventArgs e)
    {
        await AppHost!.StartAsync();

        var window = AppHost.Services.GetRequiredService<MainWindow>();
        window.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await AppHost!.StopAsync();
        base.OnExit(e);
    }
}

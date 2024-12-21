using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChatManager.Views;

namespace WeChatManager.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            Ioc.Default.ConfigureServices(
            new ServiceCollection()
            .AddSingleton<MainViewModel>()
            .AddSingleton<HomeViewModel>()
            .AddSingleton<HomeView>()
            .BuildServiceProvider()
             );
        }
        public MainViewModel Main
        {
            get
            {
                return Ioc.Default.GetService<MainViewModel>() ?? new MainViewModel();
            }
        }
        public HomeViewModel Home
        {
            get
            {
                return Ioc.Default.GetService<HomeViewModel>() ?? new HomeViewModel();
            }
        }
    }
}

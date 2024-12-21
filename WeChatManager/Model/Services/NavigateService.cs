using CommunityToolkit.Mvvm.DependencyInjection;
using Dicgo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WeChatManager.ViewModels;

namespace WeChatManager.Model.Services
{
    public class NavigateService : IGetService
    {
        public object GetService(Type t)
        {
            var vm = Ioc.Default.GetService(t);
            return vm;
        }

        public FrameworkElement GetView()
        {
            var vm = Ioc.Default.GetService<MainViewModel>();
            if (vm != null)
            {
                return vm.WorkView;
            }
            return null;
        }

        public void SetView(FrameworkElement frameworkElement)
        {
            var vm = Ioc.Default.GetService<MainViewModel>();
            if (vm != null)
            {
                vm.WorkView = frameworkElement;
            }
        }
    }
}

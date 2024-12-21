using Dicgo.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WeChatManager.Common;
using WeChatManager.ViewModels;

namespace WeChatManager.Views
{
    /// <summary>
    /// HomeView.xaml 的交互逻辑
    /// </summary>
    [TView(CommonSettings.Home, typeof(HomeView), typeof(HomeViewModel))]
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }
    }
}

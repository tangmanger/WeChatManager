using Dicgo.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChatManager.Model.Services;

namespace WeChatManager
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            TViewsHelper.Init();
            NavigateService navigateService = new NavigateService();
            NavigationHelper.Init(navigateService);
            App app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}

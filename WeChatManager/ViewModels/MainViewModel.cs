using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dicgo.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WeChatManager.Common;

namespace WeChatManager.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private FrameworkElement? workView;

        #region 属性

        /// <summary>
        /// 工作view
        /// </summary>
        public FrameworkElement? WorkView
        {
            get => workView;
            set
            {
                workView = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region 命令

        /// <summary>
        /// 加载
        /// </summary>
        public RelayCommand LoadCommand => new RelayCommand(() =>
        {
            NavigationHelper.GoTo<object>(CommonSettings.Home, null);
        });

        #endregion
    }
}

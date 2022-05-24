using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnTime3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyflyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public MyflyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new MyflyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class MyflyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyflyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public MyflyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MyflyoutPageFlyoutMenuItem>(new[]
                {
                    new MyflyoutPageFlyoutMenuItem { Id = 0, Title = "🏠   Home", TargetType = typeof(MyflyoutPageDetail) },
                    new MyflyoutPageFlyoutMenuItem { Id = 1, Title = "📊   Time Tables", TargetType = typeof(Time_Tables) },
                    new MyflyoutPageFlyoutMenuItem { Id = 2, Title = "✅   To Do List", TargetType = typeof(To_Do_List) },
                    new MyflyoutPageFlyoutMenuItem { Id = 3, Title = "⏰   Timer", TargetType = typeof(Timer) },
                    new MyflyoutPageFlyoutMenuItem { Id = 4, Title = "📅   Calendar", TargetType = typeof(Calendar) },
                    new MyflyoutPageFlyoutMenuItem { Id = 4, Title = "⚙   Settings", TargetType = typeof(Settings) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
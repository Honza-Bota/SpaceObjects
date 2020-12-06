using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpaceObjects.Model;
using Xamarin.Essentials;

namespace SpaceObjects
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPageSpaceObjects : ContentPage
    {
        public ListViewPageSpaceObjects()
        {
            InitializeComponent();
            Objects allObjects = new Objects();
            BindingContext = allObjects;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            Page p = new ObjectEditPage(((((ListView)sender).SelectedItem) as Model.Object), (BindingContext as Objects).AllObjects);
            NavigationPage np = new NavigationPage(p);
            await Application.Current.MainPage.Navigation.PushAsync(np);

            if ((sender as ListView) != null)
                (sender as ListView).SelectedItem = null;
        }
    }
}

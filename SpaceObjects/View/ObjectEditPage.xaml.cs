using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SpaceObjects.Model;
using System.ComponentModel;

namespace SpaceObjects
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class PageViewModel:INotifyPropertyChanged
    {        
        public event PropertyChangedEventHandler PropertyChanged;

        public PageViewModel(Model.Object obj)
        {
            Name = obj.Name;
            Type = obj.Type;
            Age = obj.Age;
        }

        string _Name;
        public string Name
        {
            get { return _Name; }
            set 
            {
                _Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); 
            }
        }

        string _Type;
        public string Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Type"));
            }
        }

        long _Age;
        public long Age
        {
            get { return _Age; }
            set
            {
                _Age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
            }
        }

        public Model.Object ToObject()
        {
            Model.Object am = new Model.Object
            {
                Name = this.Name,
                Type = this.Type,
                Age = this.Age
            };

            return am;
        }
    }

    public partial class ObjectEditPage : ContentPage
    {
        ObservableCollection<Model.Object> oCollection;

        public ObjectEditPage()
        {
            InitializeComponent();
        }

        public ObjectEditPage(Model.Object m, ObservableCollection<Model.Object> collection)
        {
            InitializeComponent();
            PageViewModel pvm = new PageViewModel(m);
            BindingContext = pvm;
            oCollection = collection;
        }

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            oCollection.Add((BindingContext as PageViewModel).ToObject());
            Application.Current.MainPage.Navigation.PopAsync();
        }

        private void Delete_Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
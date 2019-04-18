using HomeBookKeep5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeBookKeep5.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CostSubCatsAll : ContentPage
	{
		public CostSubCatsAll ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            string dbPath = DependencyService.Get<IPath>().GetDatabasePath(App.DBFILENAME);
            using (ApplicationContext db = new ApplicationContext(dbPath))
            {
                costSubCatList.ItemsSource = db.CostSubCats.ToList();
            }
            base.OnAppearing();
        }

        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CostSubCat selectedSubCostCat = (CostSubCat)e.SelectedItem;
            CostSCatPage costSubCatPage = new CostSCatPage
            {
                BindingContext = selectedSubCostCat
            };
            await Navigation.PushAsync(costSubCatPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateSubCostCat(object sender, EventArgs e)
        {
            CostSubCat costSubCat = new CostSubCat();
            CostSCatPage costSubCatPage = new CostSCatPage
            {
                BindingContext = costSubCat
            };
            await Navigation.PushAsync(costSubCatPage);
        }
    }
}
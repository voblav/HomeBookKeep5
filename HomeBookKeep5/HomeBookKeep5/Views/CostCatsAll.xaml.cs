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
	public partial class CostCatsAll : ContentPage
	{
		public CostCatsAll ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            string dbPath = DependencyService.Get<IPath>().GetDatabasePath(App.DBFILENAME);
            using (ApplicationContext db = new ApplicationContext(dbPath))
            {
                costCatList.ItemsSource = db.CostCats.ToList();
            }
            base.OnAppearing();
        }

        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CostCat selectedCostCat = (CostCat)e.SelectedItem;
            CostCatPage costCatPage = new CostCatPage
            {
                BindingContext = selectedCostCat
            };
            await Navigation.PushAsync(costCatPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateCostCat(object sender, EventArgs e)
        {
            CostCat costCat = new CostCat();
            CostCatPage costCatPage = new CostCatPage
            {
                BindingContext = costCat
            };
            await Navigation.PushAsync(costCatPage);
        }
    }
}
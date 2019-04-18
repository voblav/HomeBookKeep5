using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBookKeep5.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeBookKeep5.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CostSubCatCats : ContentPage
	{
		public CostSubCatCats ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            string dbPath = DependencyService.Get<IPath>().GetDatabasePath(App.DBFILENAME);
            using (ApplicationContext db = new ApplicationContext(dbPath))
            {
                

                var result = from costCat in db.CostCats
                             join costSubCat in db.CostSubCats on costCat.Id equals costSubCat.CostCatId
                             select new
                             {
                                 NameCostSubCat = costSubCat.Name,
                                 NameCostCat = costCat.Name
                             };
                costSubCatCatsList.ItemsSource = result.ToList();
            }
            base.OnAppearing();
        }
    }
}
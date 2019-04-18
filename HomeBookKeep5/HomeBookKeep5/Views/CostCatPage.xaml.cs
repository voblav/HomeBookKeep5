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
	public partial class CostCatPage : ContentPage
	{
        string dbPath;
        public CostCatPage ()
		{
			InitializeComponent ();
            dbPath = DependencyService.Get<IPath>().GetDatabasePath(App.DBFILENAME);
        }

        private void SaveCostCat(object sender, EventArgs e)
        {
            var costCat = (CostCat)BindingContext;
            if (!String.IsNullOrEmpty(costCat.Name))
            {
                using (ApplicationContext db = new ApplicationContext(dbPath))
                {
                    if (costCat.Id == 0)
                        db.CostCats.Add(costCat);
                    else
                    {
                        db.CostCats.Update(costCat);
                    }
                    db.SaveChanges();
                }
            }
            this.Navigation.PopAsync();
        }

        private void DeleteCostCat(object sender, EventArgs e)
        {
            var costCat = (CostCat)BindingContext;
            using (ApplicationContext db = new ApplicationContext(dbPath))
            {
                db.CostCats.Remove(costCat);
                db.SaveChanges();
            }
            this.Navigation.PopAsync();
        }
    }
}
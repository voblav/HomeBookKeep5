using HomeBookKeep5.Droid;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidDbPath))]
namespace HomeBookKeep5.Droid
{
    public class AndroidDbPath : IPath
    {
        public string GetDatabasePath(string filename)
        {
            return Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), filename);
        }
    }
}
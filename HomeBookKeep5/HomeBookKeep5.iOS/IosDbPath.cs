using HomeBookKeep5.iOS;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(IosDbPath))]
namespace HomeBookKeep5.iOS
{
    public class IosDbPath : IPath
    {
        public string GetDatabasePath(string sqliteFilename)
        {
            // определяем путь к бд
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", sqliteFilename);
        }
    }
}
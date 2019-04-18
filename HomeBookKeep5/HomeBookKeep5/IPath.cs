using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBookKeep5
{
    public interface IPath
    {
        string GetDatabasePath(string filename);
    }
}

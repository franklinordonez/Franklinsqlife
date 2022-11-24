using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Franklinsqlife
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection();
    }
}

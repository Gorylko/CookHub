using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Data.DbContext.Interfaces
{
    public interface IExecutor
    {
        DataSet ExecuteDataSet(string procedureName, IDictionary<string, object> values);
        

        int ExecuteNonQuery(string procedureName, IDictionary<string, object> values);
    }
}

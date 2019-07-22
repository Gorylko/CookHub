using CookHub.Data.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Data.DbContext.Realization
{
    public class ProcedureExecutor
    {
        public DataSet ExecuteDataSet(string procedureName, IDictionary<string, object> values)
        {
            DataSet dataSet = null;
            using (var connection = new SqlConnection(SqlConstants.ConnectionString))
            {
                var procedure = CreateProcedure(procedureName, values);
                procedure.Connection = connection;
                connection.Open();
                var adapter = new SqlDataAdapter();
                dataSet = new DataSet();
                adapter.Fill(dataSet);
            }
            return dataSet;
        }

        public int ExecuteNonQuery(string procedureName, IDictionary<string, object> values)
        {
            using (var connecton = new SqlConnection(SqlConstants.ConnectionString))
            {
                var procedure = CreateProcedure(procedureName, values);
                procedure.Connection = connecton;
                connecton.Open();
                return procedure.ExecuteNonQuery();
            }
        }

        private SqlCommand CreateProcedure(string procedureName, IDictionary<string, object> values)
        {
            var command = new SqlCommand
            {
                CommandText = procedureName,
                CommandType = CommandType.StoredProcedure,
            };
            if (values != null)
            {
                foreach (var param in values)
                {
                    var parameter = CreateParameter(param);
                    command.Parameters.Add(parameter);
                }
            }
            return command;
        }

        private SqlParameter CreateParameter(KeyValuePair<string, object> param)
        {
            return new SqlParameter
            {
                ParameterName = "@" + param.Key,
                Value = param.Value
            };
        }
    }
}

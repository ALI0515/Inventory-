using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Configuration;

namespace ClassLibrary2
{
    public class DbSQLServer
    {
        private string _connstring;
        public DbSQLServer(string connstring)
        { 
            _connstring = connstring;
        }
        public object GetsScalarValue(string storedProceName)
        {
            object value = null;
            using(SqlConnection con = new SqlConnection(_connstring))
            {
                using(SqlCommand cmd = new SqlCommand(storedProceName, con))
                {
                    cmd.CommandType=System.Data.CommandType.StoredProcedure;
                    con.Open();
                    value = cmd.ExecuteScalar();
                }
            }
            return value;
        }

        public object GetsScalarValue(string storedProceName,DbParameter parameter)
        {
            object value = null;
            using (SqlConnection con = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName,con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);
                    value = cmd.ExecuteScalar();
                }
            }
            return value;
        }

        public object GetsScalarValue(string storedProceName, DbParameter[] parameters)
        {
            object value = null;
            using (SqlConnection con = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    foreach(var para in parameters)
                    {
                        cmd.Parameters.AddWithValue(para.Parameter, para.Value);
                    }
                    value = cmd.ExecuteScalar();
                }
            }
            return value;
        }
        //Insert or delete or update
        public void SaveOrUpdateRecord(string storedProcName,object obj)
        {
            using (SqlConnection con = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    //parameters
                    //parameters
                    Type type= obj.GetType();
                    BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
                    PropertyInfo[] properties = type.GetProperties(flags);
                    foreach(var property in properties)
                    {
                        cmd.Parameters.AddWithValue("@"+property.Name, property.GetValue(obj, null));
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //use for display value in dropdownlist control or bind ddl list
        public DataTable GetDataList(string storedProceName)
        {
            DataTable dtData = new DataTable();
            using (SqlConnection con = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd=new SqlCommand(storedProceName,con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtData.Load(reader, 0);
                }
            }
            return dtData;
        }
    }
}

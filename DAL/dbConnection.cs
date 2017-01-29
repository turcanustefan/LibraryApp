using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DAL
{
    public class dbConnection // Database interface.
    {
        private SqlDataAdapter myAdapter;
        private SqlConnection myConn;
        
        public dbConnection()
        {
            myAdapter = new SqlDataAdapter();
            myConn = new SqlConnection("Data Source=HOME;Initial Catalog=Library;Integrated Security=True");
        }

        private SqlConnection OpenConnection()
        {
            if (myConn.State == ConnectionState.Closed || myConn.State == ConnectionState.Broken)
            {
                myConn.Open();
            }
            return myConn;
        }

        public DataTable SelectQuery(String _query, SqlParameter[] _parameters)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable myDataTable = new DataTable();
            myDataTable = null;
            DataSet myDataSet = new DataSet();

            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                if(_parameters != null)
                    myCommand.Parameters.AddRange(_parameters);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(myDataSet);
                myDataTable = myDataSet.Tables[0];
            }
            catch(SqlException e)
            {
                MessageBox.Show("Error - Connection.ExecuteSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {
                myConn.Close();
            }
            return myDataTable;
        }

        public DataTable SingleSelectQuery(String _query, SqlParameter _parameters)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable myDataTable = new DataTable();
            myDataTable = null;
            DataSet myDataSet = new DataSet();

            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                if (_parameters != null)
                    myCommand.Parameters.Add(_parameters);

                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(myDataSet);
                myDataTable = myDataSet.Tables[0];
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error - Connection.ExecuteSingleSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {
                myConn.Close();
            }
            return myDataTable;
        }

        public bool InsertQuery(String _query, SqlParameter[] _parameters)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                if(_parameters != null)
                    myCommand.Parameters.AddRange(_parameters);
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                MessageBox.Show("Error - Connection.ExecuteInsertQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
                myConn.Close();
            }
            return true;
        }

        public bool UpdateQuery(String _query, SqlParameter[] _parameters)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                if(_parameters != null)
                    myCommand.Parameters.AddRange(_parameters);
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error - Connection.ExecuteUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
                myConn.Close();
            }
            return true;
        }

        public bool ExecuteStoredProcedure(String _query, SqlParameter[] _parameters)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = OpenConnection();
                cmd = myConn.CreateCommand();
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = _query;
                if (_parameters != null)
                    cmd.Parameters.AddRange(_parameters);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected >= 1)
                    return true;
                return false;
            }
            catch(SqlException e)
            {
                MessageBox.Show("Error - Connection.ExecuteStoredProcedure - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
                myConn.Close();
            }
        }
        public int ExecuteStoredProcedureCount(String _query, SqlParameter[] _parameters)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = OpenConnection();
                cmd = myConn.CreateCommand();
                cmd.CommandTimeout = 15;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = _query;
                if (_parameters != null)
                {
                    cmd.Parameters.AddRange(_parameters);
                }
                Int32 var = (Int32)cmd.ExecuteScalar();
                return var;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error - Connection.ExecuteStoredProcedureCount - Query: " + _query + " \nException: " + ex.StackTrace.ToString());
                return 0;
            }
            finally
            {
                myConn.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace net
{
    class ConnectToSql
    {
        #region Availible
        private SqlConnection Conn;
        private SqlCommand _cmd;
        private string StrCon = null;
        private string _error;
        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public SqlConnection Connection
        {
            get { return Conn; }
        }

        public SqlCommand CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }
        #endregion
        #region Contrustor
        public ConnectToSql() //hàm kết nối
        {
            StrCon = @"Data Source=.\SQLEXPRESS;Initial Catalog= res ;Integrated Security=True";
            Conn = new SqlConnection(StrCon);
        }
        #endregion

        #region Methods
        public bool OpenConn()  //mở kết nối
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseConn()   //đóng kết nối
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        #endregion
    }
}

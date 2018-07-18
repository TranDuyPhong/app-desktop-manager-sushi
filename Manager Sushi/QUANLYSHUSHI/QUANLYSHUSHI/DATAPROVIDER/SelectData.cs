using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYSHUSHI.DATAPROVIDER
{
    public class SelectData
    {
        private string _sConnect = @"SERVER = .; DATABASE = QUANLYSHUSHI; INTEGRATED SECURITY = TRUE";

        private static volatile SelectData _selectdata;

        public static SelectData Select
        {
            get
            {
                if(_selectdata == null)
                {
                    _selectdata = new SelectData();
                }

                return _selectdata;
            }
        }

        private SelectData() { }

        public DataTable ExcuteQuery(string _sQuery, object[] _objParameters = null)
        {
            DataTable _dt = new DataTable();

            using(SqlConnection _sqlConnection = new SqlConnection(_sConnect))
            {
                _sqlConnection.Open();

                SqlCommand _sqlCommand = new SqlCommand();

                _sqlCommand.CommandType = CommandType.Text;

                _sqlCommand.CommandText = _sQuery;

                _sqlCommand.Connection = _sqlConnection;

                if(_objParameters != null)
                {
                    string[] _sArraySplit = _sQuery.Split(' ');

                    int _j = 0;

                    for(int _i = 0; _i < _sArraySplit.Length; _i++)
                    {
                        if(_sArraySplit[_i].Contains('@') == true)
                        {
                            _sqlCommand.Parameters.AddWithValue(_sArraySplit[_i], _objParameters[_j]);

                            _j++;
                        }
                    }
                }

                SqlDataAdapter _sqlAdapter = new SqlDataAdapter();

                _sqlAdapter.SelectCommand = _sqlCommand;

                _sqlCommand = null;

                _sqlAdapter.Fill(_dt);

                _sqlAdapter = null;

                _sqlConnection.Close();
            }

            return _dt;
        }

        public int ExcuteNonQuery(string _sQuery, object[] _objParameters = null)
        {
            int _iExcute = 0;

            using (SqlConnection _sqlConnection = new SqlConnection(_sConnect))
            {
                _sqlConnection.Open();

                SqlCommand _sqlCommand = new SqlCommand();

                _sqlCommand.CommandType = CommandType.Text;

                _sqlCommand.CommandText = _sQuery;

                _sqlCommand.Connection = _sqlConnection;

                if (_objParameters != null)
                {
                    string[] _sArraySplit = _sQuery.Split(' ');

                    int _j = 0;

                    for (int _i = 0; _i < _sArraySplit.Length; _i++)
                    {
                        if (_sArraySplit[_i].Contains('@') == true)
                        {
                            _sqlCommand.Parameters.AddWithValue(_sArraySplit[_i], _objParameters[_j]);

                            _j++;
                        }
                    }
                }

                _iExcute = (int)_sqlCommand.ExecuteNonQuery();

                _sqlConnection.Close();
            }

            return _iExcute;
        }
    }
}

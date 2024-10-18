﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public class AccesoADatos
    {
        private SqlConnection _connection;

        private SqlCommand _command;

        private SqlDataReader _reader;

        public SqlDataReader Reader
        {
            get { return _reader; }
        }

        public AccesoADatos()
        {
            _connection = new SqlConnection($"server=.\\SQLEXPRESS04; database = INMOBILIARIA_DB; integrated security = true");

            _command = new SqlCommand();
        }

        public void setQuery(string query)
        {
            _command.CommandType = System.Data.CommandType.Text;
            _command.CommandText = query;
        }

        public void executeRead()
        {
            _command.Connection = _connection;
            try
            {
                _connection.Open();
                _reader = _command.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void executeAction()
        {
            _command.Connection = _connection;
            try
            {
                _connection.Open();
                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int getIdEcalar()
        {
            _command.Connection = _connection;
            _connection.Open();
            return (int)_command.ExecuteScalar();
        }


        public void setParameter(string name, object value)
        {
            _command.Parameters.AddWithValue(name, value);
        }

        public void clearParams()
        {
            _command.Parameters.Clear();
        }

        public void closeConnection()
        {
            if (_reader != null)
            {
                _reader.Close();
                _connection.Close();
            }

            _connection.Close();
        }
    }
}

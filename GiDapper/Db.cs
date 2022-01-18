﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;


namespace GiDapper
{
    public class Db
    {
        private static readonly string _connectionString = Settings.Default.ConnectionString;

        public void Save<T>(T elem) where T : class
        {
            Query(c => c.Insert(elem));
        }

        public T GetById<T>(string id) where T : class
        {
            return Query(c => c.Get<T>(id));
        }

        public void Update<T>(T elem) where T: class
        {
            Query(c => c.Update(elem));
        }

        public void Delete<T>(T elem) where T : class
        {
            Query(c => c.Delete(elem));
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
           return Query(c => c.GetAll<T>());
        }

        private void Query(Action<SqlConnection> predicate)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                predicate(connection);
            }
        }

        private IEnumerable<T> Query<T>(Func<SqlConnection, IEnumerable<T>> predicate)
        {
            IEnumerable<T> res;
            using (var connection = new SqlConnection(_connectionString))
            {
                res = predicate(connection);
            }

            return res;
        }

        private T Query<T>(Func<SqlConnection, T> predicate)
        {
            T res;
            using (var connection = new SqlConnection(_connectionString))
            {
                res = predicate(connection);
            }

            return res;
        }
    }
}
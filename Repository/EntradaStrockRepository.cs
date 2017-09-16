using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Configuration;
using System.Data;
using Npgsql;
using CrvNetSync.Models;

namespace CrvNetSync.Repository
{
    public class EntradaStrockRepository
    {
		private string connectionString;
		public EntradaStrockRepository()
		{
            connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
		}

		internal IDbConnection Connection
		{
			get
			{
				return new NpgsqlConnection(connectionString);
			}
		}

		public IEnumerable<EntradaStock> FindAll()
		{
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
                return dbConnection.Query<EntradaStock>("SELECT * FROM entradastock limit 10");
			}
		}
	}
}

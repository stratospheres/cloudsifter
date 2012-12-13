using Microsoft.WindowsAzure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using DapperExtensions;
using DapperExtensions.Mapper;
using DapperExtensions.Sql;

namespace Cloudsifter.Data.Repositories
{
    public class LinkSpotter : Contracts.IRepositoryEntity<Types.LinkSpotter>
    {
        public List<Types.LinkSpotter> GetAll()
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    List<Types.LinkSpotter> entities = cn.Query<Types.LinkSpotter>("SELECT * FROM LinkSpotter").ToList();
                    cn.Close();

                    return entities;
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex);
                throw;
            }
        }

		public List<Types.LinkSpotter> GetByLinkId(int linkId)
		{
			try
			{
				string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
				using (SqlConnection cn = new SqlConnection(connectionString))
				{
					cn.Open();
					string query =
						"SELECT * FROM LinkSpotter " +
						"WHERE Id IN " +
						"	( " +
						"	SELECT LinkSpotterId FROM LinkSpotterLink " +
						"	WHERE LinkId = " + linkId.ToString() +
						"	) " +
						"ORDER BY FullName";
					List<Types.LinkSpotter> entities = cn.Query<Types.LinkSpotter>(query).ToList();
					cn.Close();

					return entities;
				}
			}
			catch (Exception ex)
			{
				Log.LogError(ex.Message, ex);
				throw;
			}
		}

        public Types.LinkSpotter GetById(int id)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    Types.LinkSpotter linkSpotter = cn.Get<Types.LinkSpotter>(id);
                    cn.Close();
                    return linkSpotter;
                }
            }
            catch (Exception ex)
            {
                Dictionary<string, object> additionalInfo = new Dictionary<string, object>();
                additionalInfo.Add("id", id);

                Log.LogError(ex.Message, ex, additionalInfo);
                throw;
            }
        }

		public Types.LinkSpotter GetByFullName(string fullName)
		{
			try
			{
				string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
				using (SqlConnection cn = new SqlConnection(connectionString))
				{
					cn.Open();
					var linkSpotters = cn.Query<Types.LinkSpotter>("select * from LinkSpotter where FullName = @FullName", new { FullName = fullName });
					cn.Close();
					return linkSpotters.FirstOrDefault<Types.LinkSpotter>();
				}
			}
			catch (Exception ex)
			{
				Dictionary<string, object> additionalInfo = new Dictionary<string, object>();
				additionalInfo.Add("FullName", fullName);

				Log.LogError(ex.Message, ex, additionalInfo);
				throw;
			}
		}

        public int Add(Types.LinkSpotter entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    int newId = cn.Insert<Types.LinkSpotter>(entity);
                    cn.Close();

                    return newId;
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex, entity.SerializeToDictionary());
                throw;
            }
        }

        public void Update(Types.LinkSpotter entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    cn.Update<Types.LinkSpotter>(entity);
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex, entity.SerializeToDictionary());
                throw;
            }
        }

        public void Delete(Types.LinkSpotter entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    cn.Delete<Types.LinkSpotter>(entity);
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex, entity.SerializeToDictionary());
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    // step 1, attempt to find the entity by id...
                    var entity = GetById(id);

                    // step 2, delete the entity
                    cn.Delete<Types.LinkSpotter>(entity);
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                Dictionary<string, object> additionalInfo = new Dictionary<string, object>();
                additionalInfo.Add("id", id);

                Log.LogError(ex.Message, ex, additionalInfo);
                throw;
            }
        }
    }
}

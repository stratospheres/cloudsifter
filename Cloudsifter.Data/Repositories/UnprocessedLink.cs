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
    public class UnprocessedLink : Contracts.IRepositoryEntity<Types.UnprocessedLink>
    {
        public List<Types.UnprocessedLink> GetAll()
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    List<Types.UnprocessedLink> entities = cn.Query<Types.UnprocessedLink>("SELECT * FROM UnprocessedLink").ToList();
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

        public Types.UnprocessedLink GetById(int id)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    Types.UnprocessedLink unprocessedLink = cn.Get<Types.UnprocessedLink>(id);
                    cn.Close();
                    return unprocessedLink;
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

		public Types.UnprocessedLink GetByTitleAndURL(string title, string url)
		{
			try
			{
				string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
				using (SqlConnection cn = new SqlConnection(connectionString))
				{
					cn.Open();
					var unprocessedLinks = cn.Query<Types.UnprocessedLink>("select * from UnprocessedLink where Title = @Title and URL = @URL", new { Title = title, URL = url });
					cn.Close();
					return unprocessedLinks.FirstOrDefault<Types.UnprocessedLink>();
				}
			}
			catch (Exception ex)
			{
				Dictionary<string, object> additionalInfo = new Dictionary<string, object>();
				additionalInfo.Add("title", title);
				additionalInfo.Add("url", url);

				Log.LogError(ex.Message, ex, additionalInfo);
				throw;
			}
		}


        public int Add(Types.UnprocessedLink entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    int newId = cn.Insert<Types.UnprocessedLink>(entity);
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

        public void Update(Types.UnprocessedLink entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    cn.Update<Types.UnprocessedLink>(entity);
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex, entity.SerializeToDictionary());
                throw;
            }
        }

        public void Delete(Types.UnprocessedLink entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    cn.Delete<Types.UnprocessedLink>(entity);
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
                    cn.Delete<Types.UnprocessedLink>(entity);
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

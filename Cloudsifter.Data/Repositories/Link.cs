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
    public class Link : Contracts.IRepositoryEntity<Types.Link>
    {
        public List<Types.Link> GetAll()
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    List<Types.Link> entities = cn.Query<Types.Link>("SELECT * FROM Link").ToList();
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

        public List<Types.Link> GetByNewsletterId(int newsletterId)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    List<Types.Link> entities = cn.Query<Types.Link>(
                        "SELECT * FROM Link " +
                        "WHERE NewsletterId = " + newsletterId.ToString()
                        ).ToList();
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

		public List<Types.Link> GetByCategoryIdAndNewsletterId(int categoryId, int newsletterId)
		{
			try
			{
				string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
				using (SqlConnection cn = new SqlConnection(connectionString))
				{
					cn.Open();
					string query =
						"SELECT * FROM Link " +
						"WHERE " +
						"	NewsletterId = " + newsletterId.ToString() + " AND " +
						"	Id IN " +
						"		( " +
						"		SELECT LinkCategory.LinkId FROM LinkCategory  " +
						"		WHERE " +
						"			LinkCategory.CategoryId = " + categoryId.ToString() +
						"		) ";
					List<Types.Link> entities = cn.Query<Types.Link>(query).ToList();
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

        public Types.Link GetById(int id)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    Types.Link link = cn.Get<Types.Link>(id);
                    cn.Close();
                    return link;
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

        public int Add(Types.Link entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    int newId = cn.Insert<Types.Link>(entity);
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

        public void Update(Types.Link entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    cn.Update<Types.Link>(entity);
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex, entity.SerializeToDictionary());
                throw;
            }
        }

        public void Delete(Types.Link entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    cn.Delete<Types.Link>(entity);
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
                    cn.Delete<Types.Link>(entity);
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

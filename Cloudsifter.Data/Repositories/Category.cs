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
    public class Category : Contracts.IRepositoryEntity<Types.Category>
    {
        public List<Types.Category> GetAll()
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    List<Types.Category> entities = cn.Query<Types.Category>("SELECT * FROM Category ORDER BY SortOrder").ToList();
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

		public List<Types.Category> GetAllRelatedToNewsletter(int newsletterId)
		{
			try
			{
				string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
				using (SqlConnection cn = new SqlConnection(connectionString))
				{
					cn.Open();
					string query =
						"SELECT * FROM Category " +
						"WHERE " +
						"	Category.Id IN " +
						"	( " +
						"		SELECT LinkCategory.CategoryId FROM LinkCategory  " +
						"		WHERE " +
						"			LinkCategory.LinkId in " +
						"			( " +
						"			SELECT Link.Id FROM Link " +
						"			WHERE Link.NewsletterId = " + newsletterId.ToString() + 
						"			) " +
						"	) " +
						"ORDER BY " +
						"	Category.SortOrder ";

					List<Types.Category> entities = cn.Query<Types.Category>(query).ToList();
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

        public Types.Category GetById(int id)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    Types.Category category = cn.Get<Types.Category>(id);
                    cn.Close();
                    return category;
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

        public int Add(Types.Category entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    int newId = cn.Insert<Types.Category>(entity);
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

        public void Update(Types.Category entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    cn.Update<Types.Category>(entity);
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex, entity.SerializeToDictionary());
                throw;
            }
        }

        public void Delete(Types.Category entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    cn.Delete<Types.Category>(entity);
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
                    cn.Delete<Types.Category>(entity);
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

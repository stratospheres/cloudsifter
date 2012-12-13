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
    public class Newsletter : Contracts.IRepositoryEntity<Types.Newsletter>
    {
        public List<Types.Newsletter> GetAll()
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    List<Types.Newsletter> entities = cn.Query<Types.Newsletter>("SELECT * FROM Newsletter ORDER BY PublishDate DESC").ToList();
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

        public Types.Newsletter GetById(int id)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    Types.Newsletter newsletter = cn.Get<Types.Newsletter>(id);
                    cn.Close();
                    return newsletter;
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

		public Types.Newsletter GetByMonthDayYear(int month, int day, int year)
		{
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    IEnumerable<Types.Newsletter> newsletters = 
						cn.Query<Types.Newsletter>(
							"SELECT * FROM NEWSLETTER " + 
							"WHERE " + 
								"MONTH(PublishDate) = " + month.ToString() + " AND " +
								"DAY(PublishDate) = " + day.ToString() + " AND " + 
								"YEAR(PublishDate) = " + year.ToString()
								);
                    cn.Close();
                    return newsletters.FirstOrDefault<Types.Newsletter>();
                }
            }
            catch (Exception ex)
            {
                Dictionary<string, object> additionalInfo = new Dictionary<string, object>();
				additionalInfo.Add("month", month);
				additionalInfo.Add("day", day);
				additionalInfo.Add("year", year);

                Log.LogError(ex.Message, ex, additionalInfo);
                throw;
            }

		}

        public int Add(Types.Newsletter entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    int newId = cn.Insert<Types.Newsletter>(entity);
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

        public void Update(Types.Newsletter entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    cn.Update<Types.Newsletter>(entity);
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex, entity.SerializeToDictionary());
                throw;
            }
        }

        public void Delete(Types.Newsletter entity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    cn.Delete<Types.Newsletter>(entity);
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
                    cn.Delete<Types.Newsletter>(entity);
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

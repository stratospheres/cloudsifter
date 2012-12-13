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
    public class LinkCategory : Contracts.IRepositoryAssociativeEntity<Types.LinkCategory>
    {
        public List<Types.LinkCategory> GetAllByLeftEntityId(int leftEntityId)
        {
            // LeftEntityId = LinkId
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    List<Types.LinkCategory> associativeEntities = cn.Query<Types.LinkCategory>(
                        "SELECT * FROM LinkCategory WHERE LinkId = " + leftEntityId.ToString()).ToList();

                    // next, join past this, into the Link table to "deep load"
                    List<Types.Category> deepObjects = cn.Query<Types.Category>(
                        "SELECT * FROM dbo.Category WHERE Id IN " +
                         "(SELECT CategoryId FROM dbo.LinkCategory WHERE LinkId = " + leftEntityId.ToString() + ")"
                         ).ToList();

                    cn.Close();

                    foreach (Types.Category deepObject in deepObjects)
                    {
                        foreach (Types.LinkCategory associativeEntity in associativeEntities)
                        {
                            if (deepObject.Id == associativeEntity.CategoryId)
                            {
                                associativeEntity.Category = deepObject;
                                break;
                            }
                        }
                    }

                    return associativeEntities;
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex);
                throw;
            }
        }

        public List<Types.LinkCategory> GetAllByRightEntityId(int rightEntityId)
        {
            // RightEntityId = CategoryId
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    List<Types.LinkCategory> associativeEntities = cn.Query<Types.LinkCategory>(
                        "SELECT * FROM LinkCategory WHERE CategoryId = " + rightEntityId.ToString()).ToList();

                    // next, join past this, into the Link table to "deep load"
                    List<Types.Link> deepObjects = cn.Query<Types.Link>(
                        "SELECT * FROM Link WHERE Id IN " +
                         "(SELECT LinkId FROM LinkCategory WHERE CategoryId = " + rightEntityId.ToString() + ")"
                         ).ToList();

                    cn.Close();

                    foreach (Types.Link deepObject in deepObjects)
                    {
                        foreach (Types.LinkCategory associativeEntity in associativeEntities)
                        {
                            if (deepObject.Id == associativeEntity.CategoryId)
                            {
                                associativeEntity.Link = deepObject;
                                break;
                            }
                        }
                    }

                    return associativeEntities;
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex);
                throw;
            }
        }

        public Types.LinkCategory GetById(int leftEntityId, int rightEntityId)
        {
            // LeftEntityId = LinkId
            // RightEntityId = CategoryId
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    var predicate1 = Predicates.Field<Types.LinkCategory>(lc => lc.LinkId, Operator.Eq, leftEntityId);
                    var predicate2 = Predicates.Field<Types.LinkCategory>(lc => lc.CategoryId, Operator.Eq, rightEntityId);
                    IPredicate[] predicates = new IPredicate[2];
                    predicates[0] = predicate1;
                    predicates[1] = predicate2;
                    IPredicateGroup predicateGroup = Predicates.Group(GroupOperator.And, predicates);

                    IQueryable<Types.LinkCategory> linkCategories = cn.GetList<Types.LinkCategory>(predicateGroup).AsQueryable<Types.LinkCategory>();
                    return linkCategories.FirstOrDefault<Types.LinkCategory>();
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex);
                throw;
            }
        }

        public System.Dynamic.ExpandoObject Add(Types.LinkCategory associativeEntity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    System.Dynamic.ExpandoObject newId = cn.Insert<Types.LinkCategory>(associativeEntity);
                    cn.Close();

                    return newId;
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex, associativeEntity.SerializeToDictionary());
                throw;
            }
        }

        public void Delete(Types.LinkCategory associativeEntity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    cn.Delete<Types.LinkCategory>(associativeEntity);
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex, associativeEntity.SerializeToDictionary());
                throw;
            }
        }

        public void Delete(int leftEntityId, int rightEntityId)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    // step 1, get the entity
                    var associativeEntity = GetById(leftEntityId, rightEntityId);

                    // step 2, delete the entity
                    cn.Delete<Types.LinkCategory>(associativeEntity);
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                Dictionary<string, object> additionalInfo = new Dictionary<string, object>();
                additionalInfo.Add("leftEntityId", leftEntityId);
                additionalInfo.Add("rightEntityId", rightEntityId);

                Log.LogError(ex.Message, ex, additionalInfo);
                throw;
            }
        }
    }
}

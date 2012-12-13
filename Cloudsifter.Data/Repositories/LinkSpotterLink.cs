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
    public class LinkSpotterLink : Contracts.IRepositoryAssociativeEntity<Types.LinkSpotterLink>
    {
        public List<Types.LinkSpotterLink> GetAllByLeftEntityId(int leftEntityId)
        {
            // LeftEntityId = LinkSpotterId
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    List<Types.LinkSpotterLink> associativeEntities = cn.Query<Types.LinkSpotterLink>(
                        "SELECT * FROM LinkSpotterLink WHERE LinkSpotterId = " + leftEntityId.ToString()
                        ).ToList();

                    // next, join past this, into the Link table to "deep load"
                    List<Types.Link> deepObjects = cn.Query<Types.Link>(
                        "SELECT * FROM dbo.Link WHERE Id IN " +
                         "(SELECT LinkId FROM dbo.LinkSpotterLink WHERE LinkSpotterId = " + leftEntityId.ToString() + ")"
                         ).ToList();

                    cn.Close();

                    foreach (Types.Link deepObject in deepObjects)
                    {
                        foreach (Types.LinkSpotterLink associativeEntity in associativeEntities)
                        {
                            if (deepObject.Id == associativeEntity.LinkId)
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

        public List<Types.LinkSpotterLink> GetAllByRightEntityId(int rightEntityId)
        {
            // RightEntityId = LinkId
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    List<Types.LinkSpotterLink> associativeEntities = cn.Query<Types.LinkSpotterLink>(
                        "SELECT * FROM LinkSpotterLink WHERE LinkId = " + rightEntityId.ToString()
                        ).ToList();

                    // next, join past this, into the Link table to "deep load"
                    List<Types.Link> deepObjects = cn.Query<Types.Link>(
                        "SELECT * FROM dbo.LinkSpotter WHERE Id IN " +
                         "(SELECT LinkSpotterId FROM dbo.LinkSpotterLink WHERE LinkId = " + rightEntityId.ToString() + ")"
                         ).ToList();

                    cn.Close();

                    foreach (Types.Link deepObject in deepObjects)
                    {
                        foreach (Types.LinkSpotterLink associativeEntity in associativeEntities)
                        {
                            if (deepObject.Id == associativeEntity.LinkId)
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

        public Types.LinkSpotterLink GetById(int leftEntityId, int rightEntityId)
        {
            // LeftEntityId = LinkSpotterId
            // RightEntityId = LinkId
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    var predicate1 = Predicates.Field<Types.LinkSpotterLink>(lsul => lsul.LinkSpotterId, Operator.Eq, leftEntityId);
                    var predicate2 = Predicates.Field<Types.LinkSpotterLink>(lsul => lsul.LinkId, Operator.Eq, rightEntityId);
                    IPredicate[] predicates = new IPredicate[2];
                    predicates[0] = predicate1;
                    predicates[1] = predicate2;
                    IPredicateGroup predicateGroup = Predicates.Group(GroupOperator.And, predicates);

                    IQueryable<Types.LinkSpotterLink> linkSpotterLinks = cn.GetList<Types.LinkSpotterLink>(predicateGroup).AsQueryable<Types.LinkSpotterLink>();
                    return linkSpotterLinks.FirstOrDefault<Types.LinkSpotterLink>();
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex);
                throw;
            }
        }

        public System.Dynamic.ExpandoObject Add(Types.LinkSpotterLink associativeEntity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    System.Dynamic.ExpandoObject newId = cn.Insert<Types.LinkSpotterLink>(associativeEntity);
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

        public void Delete(Types.LinkSpotterLink associativeEntity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    cn.Delete<Types.LinkSpotterLink>(associativeEntity);
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
                    cn.Delete<Types.LinkSpotterLink>(associativeEntity);
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

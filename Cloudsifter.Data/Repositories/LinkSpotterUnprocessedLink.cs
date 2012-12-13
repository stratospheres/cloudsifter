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
    public class LinkSpotterUnprocessedLink : Contracts.IRepositoryAssociativeEntity<Types.LinkSpotterUnprocessedLink>
    {
        public List<Types.LinkSpotterUnprocessedLink> GetAllByLeftEntityId(int leftEntityId)
        {
            // LeftEntityId = LinkSpotterId
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    List<Types.LinkSpotterUnprocessedLink> associativeEntities = cn.Query<Types.LinkSpotterUnprocessedLink>(
                        "SELECT * FROM LinkSpotterUnprocessedLink WHERE LinkSpotterId = " + leftEntityId.ToString()).ToList();

                    // next, join past this, into the UnprocessedLink table to "deep load"
                    List<Types.UnprocessedLink> deepObjects = cn.Query<Types.UnprocessedLink>(
                        "SELECT * FROM dbo.UnprocessedLink WHERE Id IN " +
                         "(SELECT UnprocessedLinkId FROM dbo.LinkSpotterUnprocessedLink WHERE LinkSpotterId = " + leftEntityId.ToString() + ")"
                         ).ToList();

                    foreach (Types.UnprocessedLink deepObject in deepObjects)
                    {
                        foreach (Types.LinkSpotterUnprocessedLink associativeEntity in associativeEntities)
                        {
                            if (deepObject.Id == associativeEntity.UnprocessedLinkId)
                            {
                                associativeEntity.UnprocessedLink = deepObject;
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

        public List<Types.LinkSpotterUnprocessedLink> GetAllByRightEntityId(int rightEntityId)
        {
            // RightEntityId = UnprocessedLinkId
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    List<Types.LinkSpotterUnprocessedLink> associativeEntities = cn.Query<Types.LinkSpotterUnprocessedLink>(
                        "SELECT * FROM LinkSpotterUnprocessedLink WHERE UnprocessedLinkId = " + rightEntityId.ToString()).ToList();

                    // next, join past this, into the UnprocessedLink table to "deep load"
                    List<Types.LinkSpotter> deepObjects = cn.Query<Types.LinkSpotter>(
                        "SELECT * FROM LinkSpotter WHERE Id IN " +
                         "(SELECT LinkSpotterId FROM LinkSpotterUnprocessedLink WHERE UnprocessedLinkId = " + rightEntityId.ToString() + ")"
                         ).ToList();

                    foreach (Types.LinkSpotter deepObject in deepObjects)
                    {
                        foreach (Types.LinkSpotterUnprocessedLink associativeEntity in associativeEntities)
                        {
                            if (deepObject.Id == associativeEntity.UnprocessedLinkId)
                            {
                                associativeEntity.LinkSpotter = deepObject;
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

        public Types.LinkSpotterUnprocessedLink GetById(int leftEntityId, int rightEntityId)
        {
            // LeftEntityId = LinkSpotterId
            // RightEntityId = UnprocessedLinkId
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    var predicate1 = Predicates.Field<Types.LinkSpotterUnprocessedLink>(lsul => lsul.LinkSpotterId, Operator.Eq, leftEntityId);
                    var predicate2 = Predicates.Field<Types.LinkSpotterUnprocessedLink>(lsul => lsul.UnprocessedLinkId, Operator.Eq, rightEntityId);
                    IPredicate[] predicates = new IPredicate[2];
                    predicates[0] = predicate1;
                    predicates[1] = predicate2;
                    IPredicateGroup predicateGroup = Predicates.Group(GroupOperator.And, predicates);
                    
                    IQueryable<Types.LinkSpotterUnprocessedLink> linkSpotterUnprocessedLinks = cn.GetList<Types.LinkSpotterUnprocessedLink>(predicateGroup).AsQueryable<Types.LinkSpotterUnprocessedLink>();
                    return linkSpotterUnprocessedLinks.FirstOrDefault<Types.LinkSpotterUnprocessedLink>();
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message, ex);
                throw;
            }
        }

        public System.Dynamic.ExpandoObject Add(Types.LinkSpotterUnprocessedLink associativeEntity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    var newId = cn.Insert<Types.LinkSpotterUnprocessedLink>(associativeEntity);
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

        public void Delete(Types.LinkSpotterUnprocessedLink associativeEntity)
        {
            try
            {
                string connectionString = CloudConfigurationManager.GetSetting("DBConnection");
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    cn.Delete<Types.LinkSpotterUnprocessedLink>(associativeEntity);
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
                    cn.Delete<Types.LinkSpotterUnprocessedLink>(associativeEntity);
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

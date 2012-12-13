using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudsifter.Data.Types
{
    public class LinkSpotterUnprocessedLinkMapper : ClassMapper<LinkSpotterUnprocessedLink>
    {
        public LinkSpotterUnprocessedLinkMapper()
        {
            Table("LinkSpotterUnprocessedLink");
            Map(i => i.LinkSpotterId).Column("LinkSpotterId").Key(KeyType.Assigned);
            Map(i => i.UnprocessedLinkId).Column("UnprocessedLinkId").Key(KeyType.Assigned);
            Map(i => i.ReportedDate).Column("ReportedDate");

            Map(i => i.LinkSpotter).Ignore();
            Map(i => i.UnprocessedLinkId).Ignore();
        }
    }

    public class LinkSpotterUnprocessedLink : Contracts.IAssociativeEntity
    {
        public int LinkSpotterId { get; set; }
        public int UnprocessedLinkId { get; set; }
        public DateTime ReportedDate { get; set; }

        public Types.LinkSpotter LinkSpotter { get; set; }
        public Types.UnprocessedLink UnprocessedLink { get; set; }

        public IDictionary<string, object> SerializeToDictionary()
        {
            Dictionary<string, object> output = new Dictionary<string, object>();

            output.Add("LinkSpotterId", LinkSpotterId);
            output.Add("UnprocessedLinkId", UnprocessedLinkId);
            output.Add("ReportedDate", ReportedDate);

            return output;
        }
    }
}

using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudsifter.Data.Types
{
    public class LinkSpotterLinkMapper : ClassMapper<LinkSpotterLink>
    {
        public LinkSpotterLinkMapper()
        {
            Table("LinkSpotterLink");
            Map(i => i.LinkSpotterId).Column("LinkSpotterId").Key(KeyType.Assigned);
            Map(i => i.LinkId).Column("LinkId").Key(KeyType.Assigned);
            Map(i => i.TimeSpotted).Column("TimeSpotted");

            Map(i => i.LinkSpotter).Ignore();
            Map(i => i.Link).Ignore();
        }
    }

    public class LinkSpotterLink : Contracts.IAssociativeEntity
    {
        public int LinkSpotterId { get; set; }
        public int LinkId { get; set; }
        public DateTime? TimeSpotted { get; set; }

        public Types.LinkSpotter LinkSpotter { get; set; }
        public Types.Link Link { get; set; }

        public IDictionary<string, object> SerializeToDictionary()
        {
            Dictionary<string, object> output = new Dictionary<string, object>();

            output.Add("LinkSpotterId", LinkSpotterId);
            output.Add("LinkId", LinkId);
            output.Add("TimeSpotted", TimeSpotted);

            return output;
        }
    }
}

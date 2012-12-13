using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudsifter.Data.Types
{
    public class LinkCategoryMapper : ClassMapper<LinkCategory>
    {
        public LinkCategoryMapper()
        {
            Table("LinkCategory");
            Map(i => i.LinkId).Column("LinkId").Key(KeyType.Assigned);
            Map(i => i.CategoryId).Column("CategoryId").Key(KeyType.Assigned);

            Map(i => i.Link).Ignore();
            Map(i => i.Category).Ignore();
        }
    }

    public class LinkCategory : Contracts.IAssociativeEntity
    {
        public int LinkId { get; set; }
        public int CategoryId { get; set; }

        public Types.Link Link { get; set; }
        public Types.Category Category { get; set; }

        public IDictionary<string, object> SerializeToDictionary()
        {
            Dictionary<string, object> output = new Dictionary<string, object>();

            output.Add("LinkId", LinkId);
            output.Add("CategoryId", CategoryId);

            return output;
        }
    }
}

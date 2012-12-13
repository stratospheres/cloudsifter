using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudsifter.Data.Types
{
    public class NewsletterMapper : ClassMapper<Newsletter>
    {
        public NewsletterMapper()
        {
            Table("Newsletter");
            Map(i => i.Id).Column("Id").Key(KeyType.Identity);
            Map(i => i.Name).Column("Name");
            Map(i => i.PublishDate).Column("PublishDate");

            Map(i => i.Links).Ignore();
        }
    }

    public class Newsletter : Contracts.IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
		public string Description { get; set; }
        public DateTime? PublishDate { get; set; }

        private bool linksLoaded = false;
        private List<Types.Link> links;
        public List<Types.Link> Links
        {
            get
            {
                if (!linksLoaded)
                {
                    Repositories.Link linkRepository = new Repositories.Link();
                    this.links = linkRepository.GetByNewsletterId(this.Id);
                    linksLoaded = true;

                    // paint ourselves into the picture of the attached entities...
                    foreach (Types.Link relatedEntity in this.links)
                        relatedEntity.Newsletter = this;
                }

                return links;
            }
        }

        public IDictionary<string, object> SerializeToDictionary()
        {
            Dictionary<string, object> output = new Dictionary<string, object>();

            output.Add("Id", Id);
            output.Add("Name", Name);
			output.Add("Description", Description);
            output.Add("PublishDate", PublishDate);

            return output;
        }
    }
}

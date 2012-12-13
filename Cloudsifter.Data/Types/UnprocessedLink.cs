using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudsifter.Data.Types
{
    public class UnprocessedLinkMapper : ClassMapper<UnprocessedLink>
    {
        public UnprocessedLinkMapper()
        {
            Table("UnprocessedLink");
            Map(i => i.Id).Column("Id").Key(KeyType.Identity);
            Map(i => i.Title).Column("Title");
            Map(i => i.URL).Column("URL");
            Map(i => i.Description).Column("Description");

            Map(i => i.LinkSpotterUnprocessedLinks).Ignore();
        }
    }

    public class UnprocessedLink : Contracts.IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }

        private bool linkSpotterUnprocessedLinksLoaded = false;
        private List<Types.LinkSpotterUnprocessedLink> linkSpotterUnprocessedLinks;
        public List<Types.LinkSpotterUnprocessedLink> LinkSpotterUnprocessedLinks
        {
            get
            {
                // lazy load if necessary
                if (!linkSpotterUnprocessedLinksLoaded)
                {
                    Repositories.LinkSpotterUnprocessedLink linkSpotterUnprocessedLinkRepository = new Repositories.LinkSpotterUnprocessedLink();
                    this.linkSpotterUnprocessedLinks = linkSpotterUnprocessedLinkRepository.GetAllByRightEntityId(this.Id);
                    linkSpotterUnprocessedLinksLoaded = true;

                    // paint ourselves into the associative entity too, for completeness...
                    foreach (Types.LinkSpotterUnprocessedLink associativeEntity in this.linkSpotterUnprocessedLinks)
                        associativeEntity.UnprocessedLink = this;
                }

                return linkSpotterUnprocessedLinks;
            }
        }

        public IDictionary<string, object> SerializeToDictionary()
        {
            Dictionary<string, object> output = new Dictionary<string, object>();

            output.Add("Id", Id);
            output.Add("Title", Title);
            output.Add("URL", URL);
            output.Add("Description", Description);

            return output;
        }
    }
}

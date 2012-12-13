using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudsifter.Data.Types
{
    public class LinkSpotterMapper : ClassMapper<LinkSpotter>
    {
        public LinkSpotterMapper()
        {
            Table("LinkSpotter");
            Map(i => i.Id).Column("Id").Key(KeyType.Identity);
            Map(i => i.FullName).Column("FullName");
            Map(i => i.URL).Column("URL");
            Map(i => i.PUID).Column("PUID");

            Map(i => i.LinkSpotterLinks).Ignore();
            Map(i => i.LinkSpotterUnprocessedLinks).Ignore();
        }
    }

    public class LinkSpotter : Contracts.IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string URL { get; set; }
        public string PUID { get; set; }

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
                    this.linkSpotterUnprocessedLinks = linkSpotterUnprocessedLinkRepository.GetAllByLeftEntityId(this.Id);
                    linkSpotterUnprocessedLinksLoaded = true;

                    // paint ourselves into the associative entity too, for completeness...
                    foreach (Types.LinkSpotterUnprocessedLink associativeEntity in this.linkSpotterUnprocessedLinks)
                        associativeEntity.LinkSpotter = this;
                }

                return linkSpotterUnprocessedLinks;
            }
        }

        private bool linkSpotterLinksLoaded = false;
        private List<Types.LinkSpotterLink> linkSpotterLinks;
        public List<Types.LinkSpotterLink> LinkSpotterLinks
        {
            get
            {
                // lazy load if necessary
                if (!linkSpotterLinksLoaded)
                {
                    Repositories.LinkSpotterLink linkSpotterLinkRepository = new Repositories.LinkSpotterLink();
                    this.linkSpotterLinks = linkSpotterLinkRepository.GetAllByLeftEntityId(this.Id);
                    linkSpotterLinksLoaded = true;

                    // paint ourselves into the associative entity too, for completeness...
                    foreach (Types.LinkSpotterLink associativeEntity in this.linkSpotterLinks)
                        associativeEntity.LinkSpotter = this;
                }

                return linkSpotterLinks;
            }
        }

        public IDictionary<string, object> SerializeToDictionary()
        {
            Dictionary<string, object> output = new Dictionary<string, object>();

            output.Add("Id", Id);
            output.Add("FullName", FullName);
            output.Add("URL", URL);
            output.Add("PUID", PUID);

            return output;
        }
    }   
}

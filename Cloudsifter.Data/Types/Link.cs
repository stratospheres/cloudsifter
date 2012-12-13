using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudsifter.Data.Types
{
    public class LinkMapper : ClassMapper<Link>
    {
        public LinkMapper()
        {
            Table("Link");
            Map(i => i.Id).Column("Id").Key(KeyType.Identity);
            Map(i => i.ParentLinkId).Column("ParentLinkId");
            Map(i => i.NewsletterId).Column("NewsletterId");
            Map(i => i.Title).Column("Title");
            Map(i => i.URL).Column("URL");
            Map(i => i.Description).Column("Description");
            Map(i => i.PlugImageURL150x150).Column("PlugImageURL150x150");

            Map(i => i.LinkSpotterLinks).Ignore();
            Map(i => i.LinkCategories).Ignore();
            Map(i => i.Newsletter).Ignore();
        }
    }

    public class Link : Contracts.IEntity
    {
        public int Id { get; set; }
        public int? ParentLinkId { get; set; }
        public int? NewsletterId { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public string PlugImageURL150x150 { get; set; }

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
                    this.linkSpotterLinks = linkSpotterLinkRepository.GetAllByRightEntityId(this.Id);
                    linkSpotterLinksLoaded = true;

                    // paint ourselves into the associative entity too, for completeness...
                    foreach (Types.LinkSpotterLink associativeEntity in this.linkSpotterLinks)
                        associativeEntity.Link = this;
                }

                return linkSpotterLinks;
            }
        }

        private bool linkCategoriesLoaded = false;
        private List<Types.LinkCategory> linkCategories;
        public List<Types.LinkCategory> LinkCategories
        {
            get
            {
                if (!linkCategoriesLoaded)
                {
                    Repositories.LinkCategory linkCategoryRepository = new Repositories.LinkCategory();
                    this.linkCategories = linkCategoryRepository.GetAllByLeftEntityId(this.Id);
                    linkCategoriesLoaded = false;

                    // paint ourselves into the associative entity too, for completeness...
                    foreach (Types.LinkCategory associativeEntity in this.linkCategories)
                        associativeEntity.Link = this;
                }

                return linkCategories;
            }
        }

        private bool newsletterLoaded = false;
        private Types.Newsletter newsletter;
        public Types.Newsletter Newsletter
        {
            get
            {
                if (!newsletterLoaded)
                {
                    if (this.NewsletterId.HasValue)
                    {
                        Repositories.Newsletter newsletterRepository = new Repositories.Newsletter();
                        this.newsletter = newsletterRepository.GetById(this.NewsletterId.Value);
                    }
                    else
                        this.newsletter = null;

                    newsletterLoaded = true;
                }

                return newsletter;
            }
            set
            {
                newsletter = value;
                newsletterLoaded = true;
            }
        }

        public IDictionary<string, object> SerializeToDictionary()
        {
            Dictionary<string, object> output = new Dictionary<string,object>();
            
            output.Add("Id", Id);
            output.Add("ParentLinkId", ParentLinkId);
            output.Add("NewsletterId", NewsletterId);
            output.Add("Title", Title);
            output.Add("URL", Title);
            output.Add("Description", Description);
            output.Add("PlugImageURL150x150", PlugImageURL150x150);

            return output;
        }
    }
}

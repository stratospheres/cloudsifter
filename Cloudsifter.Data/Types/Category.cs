using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudsifter.Data.Types
{
    public class CategoryMapper : ClassMapper<Category>
    {
        public CategoryMapper()
        {
            Table("Category");
            Map(i => i.Id).Column("Id").Key(KeyType.Identity);
            Map(i => i.Name).Column("Name");

            Map(i => i.LinkCategories).Ignore();
        }
    }

    public class Category : Contracts.IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
		public int SortOrder { get; set; }

        private bool linkCategoriesLoaded = false;
        private List<Types.LinkCategory> linkCategories;
        public List<Types.LinkCategory> LinkCategories
        {
            get
            {
                if (!linkCategoriesLoaded)
                {
                    Repositories.LinkCategory linkCategoryRepository = new Repositories.LinkCategory();
                    this.linkCategories = linkCategoryRepository.GetAllByRightEntityId(this.Id);
                    linkCategoriesLoaded = false;

                    // paint ourselves into the associative entity too, for completeness...
                    foreach (Types.LinkCategory associativeEntity in this.linkCategories)
                        associativeEntity.Category = this;
                }

                return linkCategories;
            }
        }
		public List<Types.Link> LinksByNewsletterId(int newsletterId)
		{
			Data.Repositories.Link linkRepository = new Repositories.Link();
			return linkRepository.GetByCategoryIdAndNewsletterId(this.Id, newsletterId);
		}

        public IDictionary<string, object> SerializeToDictionary()
        {
            Dictionary<string, object> output = new Dictionary<string, object>();

            output.Add("Id", Id);
            output.Add("Name", Name);
			output.Add("SortOrder", SortOrder);

            return output;
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication.Implementation
{
    
    #region Category
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/cloudsifterData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Category :
        global::LightSwitchApplication.Category.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnNameChanged()
        {
            this.___OnPropertyChanged("Name");
        }
        
        partial void OnSortOrderChanged()
        {
            this.___OnPropertyChanged("SortOrder");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Category.DetailsClass.IImplementation.LinkCategories
        {
            get
            {
                return this.LinkCategories;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkCategory> __LinkCategories
        {
            get
            {
                if (this.___LinkCategories == null)
                {
                    this.___LinkCategories = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkCategory>(
                        this,
                        "LinkCategories",
                        () => this._LinkCategories,
                        e => global::System.Object.Equals(e.CategoryId, this.Id));
                }
                return this.___LinkCategories;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkCategory> ___LinkCategories;
        
    }
    #endregion
    
    #region Link
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/cloudsifterData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Link :
        global::LightSwitchApplication.Link.DetailsClass.IImplementation
    {
        partial void OnParentLinkIdChanged()
        {
            this.___OnPropertyChanged("ParentLinkId");
            this.___OnPropertyChanged("Link1");
        }
        
        partial void OnNewsletterIdChanged()
        {
            this.___OnPropertyChanged("NewsletterId");
            this.___OnPropertyChanged("Newsletter");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnTitleChanged()
        {
            this.___OnPropertyChanged("Title");
        }
        
        partial void OnURLChanged()
        {
            this.___OnPropertyChanged("URL");
        }
        
        partial void OnDescriptionChanged()
        {
            this.___OnPropertyChanged("Description");
        }
        
        partial void OnPlugImageURL150x150Changed()
        {
            this.___OnPropertyChanged("PlugImageURL150x150");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Link.DetailsClass.IImplementation.Links
        {
            get
            {
                return this.Links;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Link> __Links
        {
            get
            {
                if (this.___Links == null)
                {
                    this.___Links = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Link>(
                        this,
                        "Links",
                        () => this._Links,
                        e => global::System.Object.Equals(e.ParentLinkId, this.Id));
                }
                return this.___Links;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Link> ___Links;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Link.DetailsClass.IImplementation.Link1
        {
            get
            {
                return this.Link1;
            }
            set
            {
                this.Link1 = (global::LightSwitchApplication.Implementation.Link)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Link> __Link1
        {
            get
            {
                if (this.___Link1 == null)
                {
                    this.___Link1 = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Link>(
                        this,
                        "Link1",
                        new string[] { "ParentLinkId" },
                        e => global::System.Object.Equals(e.Id, this.ParentLinkId),
                        () => this._Link1,
                        e => this._Link1 = e);
                }
                return this.___Link1;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Link> ___Link1;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Link.DetailsClass.IImplementation.Newsletter
        {
            get
            {
                return this.Newsletter;
            }
            set
            {
                this.Newsletter = (global::LightSwitchApplication.Implementation.Newsletter)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Newsletter> __Newsletter
        {
            get
            {
                if (this.___Newsletter == null)
                {
                    this.___Newsletter = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Newsletter>(
                        this,
                        "Newsletter",
                        new string[] { "NewsletterId" },
                        e => global::System.Object.Equals(e.Id, this.NewsletterId),
                        () => this._Newsletter,
                        e => this._Newsletter = e);
                }
                return this.___Newsletter;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Newsletter> ___Newsletter;
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Link.DetailsClass.IImplementation.LinkCategories
        {
            get
            {
                return this.LinkCategories;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkCategory> __LinkCategories
        {
            get
            {
                if (this.___LinkCategories == null)
                {
                    this.___LinkCategories = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkCategory>(
                        this,
                        "LinkCategories",
                        () => this._LinkCategories,
                        e => global::System.Object.Equals(e.LinkId, this.Id));
                }
                return this.___LinkCategories;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkCategory> ___LinkCategories;
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Link.DetailsClass.IImplementation.LinkSpotterLinks
        {
            get
            {
                return this.LinkSpotterLinks;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkSpotterLink> __LinkSpotterLinks
        {
            get
            {
                if (this.___LinkSpotterLinks == null)
                {
                    this.___LinkSpotterLinks = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkSpotterLink>(
                        this,
                        "LinkSpotterLinks",
                        () => this._LinkSpotterLinks,
                        e => global::System.Object.Equals(e.LinkId, this.Id));
                }
                return this.___LinkSpotterLinks;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkSpotterLink> ___LinkSpotterLinks;
        
    }
    #endregion
    
    #region LinkCategory
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/cloudsifterData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class LinkCategory :
        global::LightSwitchApplication.LinkCategory.DetailsClass.IImplementation
    {
        partial void OnCategoryIdChanged()
        {
            this.___OnPropertyChanged("CategoryId");
            this.___OnPropertyChanged("Category");
        }
        
        partial void OnLinkIdChanged()
        {
            this.___OnPropertyChanged("LinkId");
            this.___OnPropertyChanged("Link");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.LinkCategory.DetailsClass.IImplementation.Category
        {
            get
            {
                return this.Category;
            }
            set
            {
                this.Category = (global::LightSwitchApplication.Implementation.Category)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Category> __Category
        {
            get
            {
                if (this.___Category == null)
                {
                    this.___Category = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Category>(
                        this,
                        "Category",
                        new string[] { "CategoryId" },
                        e => global::System.Object.Equals(e.Id, this.CategoryId),
                        () => this._Category,
                        e => this._Category = e);
                }
                return this.___Category;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Category> ___Category;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.LinkCategory.DetailsClass.IImplementation.Link
        {
            get
            {
                return this.Link;
            }
            set
            {
                this.Link = (global::LightSwitchApplication.Implementation.Link)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Link> __Link
        {
            get
            {
                if (this.___Link == null)
                {
                    this.___Link = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Link>(
                        this,
                        "Link",
                        new string[] { "LinkId" },
                        e => global::System.Object.Equals(e.Id, this.LinkId),
                        () => this._Link,
                        e => this._Link = e);
                }
                return this.___Link;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Link> ___Link;
        
    }
    #endregion
    
    #region LinkSpotter
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/cloudsifterData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class LinkSpotter :
        global::LightSwitchApplication.LinkSpotter.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnFullNameChanged()
        {
            this.___OnPropertyChanged("FullName");
        }
        
        partial void OnURLChanged()
        {
            this.___OnPropertyChanged("URL");
        }
        
        partial void OnPUIDChanged()
        {
            this.___OnPropertyChanged("PUID");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.LinkSpotter.DetailsClass.IImplementation.LinkSpotterLinks
        {
            get
            {
                return this.LinkSpotterLinks;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkSpotterLink> __LinkSpotterLinks
        {
            get
            {
                if (this.___LinkSpotterLinks == null)
                {
                    this.___LinkSpotterLinks = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkSpotterLink>(
                        this,
                        "LinkSpotterLinks",
                        () => this._LinkSpotterLinks,
                        e => global::System.Object.Equals(e.LinkSpotterId, this.Id));
                }
                return this.___LinkSpotterLinks;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkSpotterLink> ___LinkSpotterLinks;
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.LinkSpotter.DetailsClass.IImplementation.LinkSpotterUnprocessedLinks
        {
            get
            {
                return this.LinkSpotterUnprocessedLinks;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkSpotterUnprocessedLink> __LinkSpotterUnprocessedLinks
        {
            get
            {
                if (this.___LinkSpotterUnprocessedLinks == null)
                {
                    this.___LinkSpotterUnprocessedLinks = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkSpotterUnprocessedLink>(
                        this,
                        "LinkSpotterUnprocessedLinks",
                        () => this._LinkSpotterUnprocessedLinks,
                        e => global::System.Object.Equals(e.LinkSpotterId, this.Id));
                }
                return this.___LinkSpotterUnprocessedLinks;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkSpotterUnprocessedLink> ___LinkSpotterUnprocessedLinks;
        
    }
    #endregion
    
    #region LinkSpotterLink
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/cloudsifterData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class LinkSpotterLink :
        global::LightSwitchApplication.LinkSpotterLink.DetailsClass.IImplementation
    {
        partial void OnLinkIdChanged()
        {
            this.___OnPropertyChanged("LinkId");
            this.___OnPropertyChanged("Link");
        }
        
        partial void OnLinkSpotterIdChanged()
        {
            this.___OnPropertyChanged("LinkSpotterId");
            this.___OnPropertyChanged("LinkSpotter");
        }
        
        partial void OnTimeSpottedChanged()
        {
            this.___OnPropertyChanged("TimeSpotted");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.LinkSpotterLink.DetailsClass.IImplementation.Link
        {
            get
            {
                return this.Link;
            }
            set
            {
                this.Link = (global::LightSwitchApplication.Implementation.Link)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Link> __Link
        {
            get
            {
                if (this.___Link == null)
                {
                    this.___Link = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Link>(
                        this,
                        "Link",
                        new string[] { "LinkId" },
                        e => global::System.Object.Equals(e.Id, this.LinkId),
                        () => this._Link,
                        e => this._Link = e);
                }
                return this.___Link;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Link> ___Link;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.LinkSpotterLink.DetailsClass.IImplementation.LinkSpotter
        {
            get
            {
                return this.LinkSpotter;
            }
            set
            {
                this.LinkSpotter = (global::LightSwitchApplication.Implementation.LinkSpotter)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.LinkSpotter> __LinkSpotter
        {
            get
            {
                if (this.___LinkSpotter == null)
                {
                    this.___LinkSpotter = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.LinkSpotter>(
                        this,
                        "LinkSpotter",
                        new string[] { "LinkSpotterId" },
                        e => global::System.Object.Equals(e.Id, this.LinkSpotterId),
                        () => this._LinkSpotter,
                        e => this._LinkSpotter = e);
                }
                return this.___LinkSpotter;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.LinkSpotter> ___LinkSpotter;
        
    }
    #endregion
    
    #region LinkSpotterUnprocessedLink
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/cloudsifterData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class LinkSpotterUnprocessedLink :
        global::LightSwitchApplication.LinkSpotterUnprocessedLink.DetailsClass.IImplementation
    {
        partial void OnLinkSpotterIdChanged()
        {
            this.___OnPropertyChanged("LinkSpotterId");
            this.___OnPropertyChanged("LinkSpotter");
        }
        
        partial void OnUnprocessedLinkIdChanged()
        {
            this.___OnPropertyChanged("UnprocessedLinkId");
            this.___OnPropertyChanged("UnprocessedLink");
        }
        
        partial void OnReportedDateChanged()
        {
            this.___OnPropertyChanged("ReportedDate");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.LinkSpotterUnprocessedLink.DetailsClass.IImplementation.LinkSpotter
        {
            get
            {
                return this.LinkSpotter;
            }
            set
            {
                this.LinkSpotter = (global::LightSwitchApplication.Implementation.LinkSpotter)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.LinkSpotter> __LinkSpotter
        {
            get
            {
                if (this.___LinkSpotter == null)
                {
                    this.___LinkSpotter = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.LinkSpotter>(
                        this,
                        "LinkSpotter",
                        new string[] { "LinkSpotterId" },
                        e => global::System.Object.Equals(e.Id, this.LinkSpotterId),
                        () => this._LinkSpotter,
                        e => this._LinkSpotter = e);
                }
                return this.___LinkSpotter;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.LinkSpotter> ___LinkSpotter;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.LinkSpotterUnprocessedLink.DetailsClass.IImplementation.UnprocessedLink
        {
            get
            {
                return this.UnprocessedLink;
            }
            set
            {
                this.UnprocessedLink = (global::LightSwitchApplication.Implementation.UnprocessedLink)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.UnprocessedLink> __UnprocessedLink
        {
            get
            {
                if (this.___UnprocessedLink == null)
                {
                    this.___UnprocessedLink = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.UnprocessedLink>(
                        this,
                        "UnprocessedLink",
                        new string[] { "UnprocessedLinkId" },
                        e => global::System.Object.Equals(e.Id, this.UnprocessedLinkId),
                        () => this._UnprocessedLink,
                        e => this._UnprocessedLink = e);
                }
                return this.___UnprocessedLink;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.UnprocessedLink> ___UnprocessedLink;
        
    }
    #endregion
    
    #region Newsletter
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/cloudsifterData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Newsletter :
        global::LightSwitchApplication.Newsletter.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnNameChanged()
        {
            this.___OnPropertyChanged("Name");
        }
        
        partial void OnDescriptionChanged()
        {
            this.___OnPropertyChanged("Description");
        }
        
        partial void OnPublishDateChanged()
        {
            this.___OnPropertyChanged("PublishDate");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Newsletter.DetailsClass.IImplementation.Links
        {
            get
            {
                return this.Links;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Link> __Links
        {
            get
            {
                if (this.___Links == null)
                {
                    this.___Links = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Link>(
                        this,
                        "Links",
                        () => this._Links,
                        e => global::System.Object.Equals(e.NewsletterId, this.Id));
                }
                return this.___Links;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Link> ___Links;
        
    }
    #endregion
    
    #region UnprocessedLink
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/cloudsifterData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class UnprocessedLink :
        global::LightSwitchApplication.UnprocessedLink.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnTitleChanged()
        {
            this.___OnPropertyChanged("Title");
        }
        
        partial void OnURLChanged()
        {
            this.___OnPropertyChanged("URL");
        }
        
        partial void OnDescriptionChanged()
        {
            this.___OnPropertyChanged("Description");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.UnprocessedLink.DetailsClass.IImplementation.LinkSpotterUnprocessedLinks
        {
            get
            {
                return this.LinkSpotterUnprocessedLinks;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkSpotterUnprocessedLink> __LinkSpotterUnprocessedLinks
        {
            get
            {
                if (this.___LinkSpotterUnprocessedLinks == null)
                {
                    this.___LinkSpotterUnprocessedLinks = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkSpotterUnprocessedLink>(
                        this,
                        "LinkSpotterUnprocessedLinks",
                        () => this._LinkSpotterUnprocessedLinks,
                        e => global::System.Object.Equals(e.UnprocessedLinkId, this.Id));
                }
                return this.___LinkSpotterUnprocessedLinks;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LinkSpotterUnprocessedLink> ___LinkSpotterUnprocessedLinks;
        
    }
    #endregion
    
    #region cloudsifterDataObjectContext
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class cloudsifterDataObjectContext
    {
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Category))
            {
                return new global::LightSwitchApplication.Implementation.Category();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Link))
            {
                return new global::LightSwitchApplication.Implementation.Link();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.LinkCategory))
            {
                return new global::LightSwitchApplication.Implementation.LinkCategory();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.LinkSpotter))
            {
                return new global::LightSwitchApplication.Implementation.LinkSpotter();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.LinkSpotterLink))
            {
                return new global::LightSwitchApplication.Implementation.LinkSpotterLink();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.LinkSpotterUnprocessedLink))
            {
                return new global::LightSwitchApplication.Implementation.LinkSpotterUnprocessedLink();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Newsletter))
            {
                return new global::LightSwitchApplication.Implementation.Newsletter();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.UnprocessedLink))
            {
                return new global::LightSwitchApplication.Implementation.UnprocessedLink();
            }
            return null;
        }
    }
    #endregion
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.cloudsifterData))
            {
                return new global::LightSwitchApplication.cloudsifterData();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.cloudsifterData))
            {
                return new global::LightSwitchApplication.Implementation.cloudsifterDataObjectContext(global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext.CreateServiceUri("../cloudsifterData.svc"));
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Category) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Category);
            }
            if (typeof(global::LightSwitchApplication.Link) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Link);
            }
            if (typeof(global::LightSwitchApplication.LinkCategory) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.LinkCategory);
            }
            if (typeof(global::LightSwitchApplication.LinkSpotter) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.LinkSpotter);
            }
            if (typeof(global::LightSwitchApplication.LinkSpotterLink) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.LinkSpotterLink);
            }
            if (typeof(global::LightSwitchApplication.LinkSpotterUnprocessedLink) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.LinkSpotterUnprocessedLink);
            }
            if (typeof(global::LightSwitchApplication.Newsletter) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Newsletter);
            }
            if (typeof(global::LightSwitchApplication.UnprocessedLink) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.UnprocessedLink);
            }
            return null;
        }
    }
}
﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    public sealed partial class LinkCategory : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the LinkCategory entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public LinkCategory()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public LinkCategory(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.LinkCategory> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.LinkCategory.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void LinkCategory_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void LinkCategory_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int LinkId
        {
            get
            {
                return global::LightSwitchApplication.LinkCategory.DetailsClass.GetValue(this, global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.LinkId);
            }
            set
            {
                global::LightSwitchApplication.LinkCategory.DetailsClass.SetValue(this, global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.LinkId, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void LinkId_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void LinkId_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void LinkId_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int CategoryId
        {
            get
            {
                return global::LightSwitchApplication.LinkCategory.DetailsClass.GetValue(this, global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.CategoryId);
            }
            set
            {
                global::LightSwitchApplication.LinkCategory.DetailsClass.SetValue(this, global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.CategoryId, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CategoryId_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CategoryId_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CategoryId_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Category Category
        {
            get
            {
                return global::LightSwitchApplication.LinkCategory.DetailsClass.GetValue(this, global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.Category);
            }
            set
            {
                global::LightSwitchApplication.LinkCategory.DetailsClass.SetValue(this, global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.Category, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Category_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Category_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Category_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Link Link
        {
            get
            {
                return global::LightSwitchApplication.LinkCategory.DetailsClass.GetValue(this, global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.Link);
            }
            set
            {
                global::LightSwitchApplication.LinkCategory.DetailsClass.SetValue(this, global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.Link, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Link_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Link_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Link_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.LinkCategory,
                global::LightSwitchApplication.LinkCategory.DetailsClass,
                global::LightSwitchApplication.LinkCategory.DetailsClass.IImplementation,
                global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.LinkId;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass>.Entry
                __LinkCategoryEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass>.Entry(
                    global::LightSwitchApplication.LinkCategory.DetailsClass.__LinkCategory_CreateNew,
                    global::LightSwitchApplication.LinkCategory.DetailsClass.__LinkCategory_Created,
                    global::LightSwitchApplication.LinkCategory.DetailsClass.__LinkCategory_AllowSaveWithErrors);
            private static global::LightSwitchApplication.LinkCategory __LinkCategory_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.LinkCategory> es)
            {
                return new global::LightSwitchApplication.LinkCategory(es);
            }
            private static void __LinkCategory_Created(global::LightSwitchApplication.LinkCategory e)
            {
                e.LinkCategory_Created();
            }
            private static bool __LinkCategory_AllowSaveWithErrors(global::LightSwitchApplication.LinkCategory e)
            {
                bool result = false;
                e.LinkCategory_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, int> LinkId
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.LinkId) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, int> CategoryId
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.CategoryId) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, global::LightSwitchApplication.Category> Category
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.Category) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, global::LightSwitchApplication.Category>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, global::LightSwitchApplication.Link> Link
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.Link) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, global::LightSwitchApplication.Link>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int LinkId { get; set; }
                new int CategoryId { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Category { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Link { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, int>.Entry
                    LinkId = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, int>.Entry(
                        "LinkId",
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._LinkId_Stub,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._LinkId_ComputeIsReadOnly,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._LinkId_Validate,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._LinkId_GetImplementationValue,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._LinkId_SetImplementationValue,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._LinkId_OnValueChanged);
                private static void _LinkId_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.LinkCategory.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, int>.Data> c, global::LightSwitchApplication.LinkCategory.DetailsClass d, object sf)
                {
                    c(d, ref d._LinkId, sf);
                }
                private static bool _LinkId_ComputeIsReadOnly(global::LightSwitchApplication.LinkCategory e)
                {
                    bool result = false;
                    e.LinkId_IsReadOnly(ref result);
                    return result;
                }
                private static void _LinkId_Validate(global::LightSwitchApplication.LinkCategory e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.LinkId_Validate(r);
                }
                private static int _LinkId_GetImplementationValue(global::LightSwitchApplication.LinkCategory.DetailsClass d)
                {
                    return d.ImplementationEntity.LinkId;
                }
                private static void _LinkId_SetImplementationValue(global::LightSwitchApplication.LinkCategory.DetailsClass d, int v)
                {
                    d.ImplementationEntity.LinkId = v;
                }
                private static void _LinkId_OnValueChanged(global::LightSwitchApplication.LinkCategory e)
                {
                    e.LinkId_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, int>.Entry
                    CategoryId = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, int>.Entry(
                        "CategoryId",
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._CategoryId_Stub,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._CategoryId_ComputeIsReadOnly,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._CategoryId_Validate,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._CategoryId_GetImplementationValue,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._CategoryId_SetImplementationValue,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._CategoryId_OnValueChanged);
                private static void _CategoryId_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.LinkCategory.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, int>.Data> c, global::LightSwitchApplication.LinkCategory.DetailsClass d, object sf)
                {
                    c(d, ref d._CategoryId, sf);
                }
                private static bool _CategoryId_ComputeIsReadOnly(global::LightSwitchApplication.LinkCategory e)
                {
                    bool result = false;
                    e.CategoryId_IsReadOnly(ref result);
                    return result;
                }
                private static void _CategoryId_Validate(global::LightSwitchApplication.LinkCategory e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.CategoryId_Validate(r);
                }
                private static int _CategoryId_GetImplementationValue(global::LightSwitchApplication.LinkCategory.DetailsClass d)
                {
                    return d.ImplementationEntity.CategoryId;
                }
                private static void _CategoryId_SetImplementationValue(global::LightSwitchApplication.LinkCategory.DetailsClass d, int v)
                {
                    d.ImplementationEntity.CategoryId = v;
                }
                private static void _CategoryId_OnValueChanged(global::LightSwitchApplication.LinkCategory e)
                {
                    e.CategoryId_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, global::LightSwitchApplication.Category>.Entry
                    Category = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, global::LightSwitchApplication.Category>.Entry(
                        "Category",
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Category_Stub,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Category_ComputeIsReadOnly,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Category_Validate,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Category_GetCoreImplementationValue,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Category_GetImplementationValue,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Category_SetImplementationValue,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Category_Refresh,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Category_OnValueChanged);
                private static void _Category_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.LinkCategory.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, global::LightSwitchApplication.Category>.Data> c, global::LightSwitchApplication.LinkCategory.DetailsClass d, object sf)
                {
                    c(d, ref d._Category, sf);
                }
                private static bool _Category_ComputeIsReadOnly(global::LightSwitchApplication.LinkCategory e)
                {
                    bool result = false;
                    e.Category_IsReadOnly(ref result);
                    return result;
                }
                private static void _Category_Validate(global::LightSwitchApplication.LinkCategory e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Category_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Category_GetCoreImplementationValue(global::LightSwitchApplication.LinkCategory.DetailsClass d)
                {
                    return d.ImplementationEntity.Category;
                }
                private static global::LightSwitchApplication.Category _Category_GetImplementationValue(global::LightSwitchApplication.LinkCategory.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Category, global::LightSwitchApplication.Category.DetailsClass>(global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.Category, ref d._Category);
                }
                private static void _Category_SetImplementationValue(global::LightSwitchApplication.LinkCategory.DetailsClass d, global::LightSwitchApplication.Category v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.Category, ref d._Category, (i, ev) => i.Category = ev, v);
                }
                private static void _Category_Refresh(global::LightSwitchApplication.LinkCategory.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.Category, ref d._Category);
                }
                private static void _Category_OnValueChanged(global::LightSwitchApplication.LinkCategory e)
                {
                    e.Category_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, global::LightSwitchApplication.Link>.Entry
                    Link = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, global::LightSwitchApplication.Link>.Entry(
                        "Link",
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Link_Stub,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Link_ComputeIsReadOnly,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Link_Validate,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Link_GetCoreImplementationValue,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Link_GetImplementationValue,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Link_SetImplementationValue,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Link_Refresh,
                        global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties._Link_OnValueChanged);
                private static void _Link_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.LinkCategory.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, global::LightSwitchApplication.Link>.Data> c, global::LightSwitchApplication.LinkCategory.DetailsClass d, object sf)
                {
                    c(d, ref d._Link, sf);
                }
                private static bool _Link_ComputeIsReadOnly(global::LightSwitchApplication.LinkCategory e)
                {
                    bool result = false;
                    e.Link_IsReadOnly(ref result);
                    return result;
                }
                private static void _Link_Validate(global::LightSwitchApplication.LinkCategory e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Link_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Link_GetCoreImplementationValue(global::LightSwitchApplication.LinkCategory.DetailsClass d)
                {
                    return d.ImplementationEntity.Link;
                }
                private static global::LightSwitchApplication.Link _Link_GetImplementationValue(global::LightSwitchApplication.LinkCategory.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Link, global::LightSwitchApplication.Link.DetailsClass>(global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.Link, ref d._Link);
                }
                private static void _Link_SetImplementationValue(global::LightSwitchApplication.LinkCategory.DetailsClass d, global::LightSwitchApplication.Link v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.Link, ref d._Link, (i, ev) => i.Link = ev, v);
                }
                private static void _Link_Refresh(global::LightSwitchApplication.LinkCategory.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.LinkCategory.DetailsClass.PropertySetProperties.Link, ref d._Link);
                }
                private static void _Link_OnValueChanged(global::LightSwitchApplication.LinkCategory e)
                {
                    e.Link_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, int>.Data _LinkId;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, int>.Data _CategoryId;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, global::LightSwitchApplication.Category>.Data _Category;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LinkCategory, global::LightSwitchApplication.LinkCategory.DetailsClass, global::LightSwitchApplication.Link>.Data _Link;
            
        }
    
        #endregion
    }
    
    #endregion
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpComponentsLoader
{
    using System;
    using System.Collections.Generic;
    
    public partial class Component
    {
        public int ComponentID { get; set; }
        public int ComponentGroupID { get; set; }
        public int MenuCatalogItemID { get; set; }
        public bool Active { get; set; }
    
        public virtual ComponentGroup ComponentGroup { get; set; }
        public virtual MenuCatalogItem MenuCatalogItem { get; set; }
    }
}

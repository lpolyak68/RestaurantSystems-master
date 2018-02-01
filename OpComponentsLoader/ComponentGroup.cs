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
    
    public partial class ComponentGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ComponentGroup()
        {
            this.Components = new HashSet<Component>();
        }
    
        public int ComponentGroupID { get; set; }
        public string ComponentGroupName { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int MenuCatalogItemID { get; set; }
        public int Sequence { get; set; }
        public string ComponentGroupNameList { get; set; }
        public string MaxList { get; set; }
        public string MinList { get; set; }
        public string Details { get; set; }
        public Nullable<bool> IsRequired { get; set; }
        public bool Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Component> Components { get; set; }
        public virtual MenuCatalogItem MenuCatalogItem { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A1ToCatalogMenuLoader
{
    using System;
    using System.Collections.Generic;
    
    public partial class Merchandise
    {
        public int iMerchandiseID { get; set; }
        public Nullable<int> iPriceGroupID { get; set; }
        public int iMerchandiseDeptID { get; set; }
        public int iAiiNum { get; set; }
        public string sItemName { get; set; }
        public string sOrderName { get; set; }
        public int iCookTime { get; set; }
        public int iPrepOrder { get; set; }
        public int iQtyAvail { get; set; }
        public bool bIsModifier { get; set; }
        public bool bIsLocked { get; set; }
        public bool bIsDaily { get; set; }
        public bool bPrintSameLine { get; set; }
        public bool bForceRecipe { get; set; }
        public bool bNotSold { get; set; }
        public bool bPromptForPrice { get; set; }
        public bool bPrintOnOrder { get; set; }
        public bool bPrintOnReceipt { get; set; }
        public bool bIgnoreItem { get; set; }
        public bool bPrintRecipe { get; set; }
        public bool bBeverage { get; set; }
        public bool bEntreAppetizer { get; set; }
        public bool bDeleted { get; set; }
        public System.DateTime dtModified { get; set; }
        public bool bGroupingItem { get; set; }
        public bool bPrintGroupItems { get; set; }
        public bool bAllowPartialSend { get; set; }
        public string CostCenter { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Inventory_Management_System.Models
{

using System;
    using System.Collections.Generic;
    
public partial class HistoryTransaction
{

    public int Transact_ID { get; set; }

    public int CartID { get; set; }

    public int user_ID { get; set; }

    public int productID { get; set; }

    public Nullable<int> categoryID { get; set; }



    public virtual Accounts Accounts { get; set; }

    public virtual Cart Cart { get; set; }

    public virtual Category Category { get; set; }

    public virtual Products Products { get; set; }

}

}

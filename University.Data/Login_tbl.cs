
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace University.Data
{

using System;
    using System.Collections.Generic;
    
public partial class Login_tbl
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Login_tbl()
    {

        this.Login_tbl1 = new HashSet<Login_tbl>();

    }


    public int ID { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public Nullable<decimal> RoleID { get; set; }

    public Nullable<System.DateTime> CreatedDate { get; set; }

    public Nullable<decimal> CreatedBy { get; set; }

    public Nullable<System.DateTime> DeletedDate { get; set; }

    public Nullable<decimal> DeletedBy { get; set; }

    public Nullable<bool> IsDeleted { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public Nullable<decimal> CustomerId { get; set; }

    public Nullable<int> AdminId { get; set; }

    public string MobileNo { get; set; }



    public virtual Role Role { get; set; }

    public virtual Customer Customer { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Login_tbl> Login_tbl1 { get; set; }

    public virtual Login_tbl Login_tbl2 { get; set; }

}

}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Voting_Syste_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        public long National_ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Circle_ID { get; set; }
        public string Gender { get; set; }
        public int local_Vote { get; set; }
        public int Party_Vote { get; set; }
        public int White_Local_Vote { get; set; }
        public int White_Party_Vote { get; set; }
    }
}

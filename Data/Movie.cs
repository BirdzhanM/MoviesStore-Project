//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesStore.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Author { get; set; }
        public int Genre { get; set; }
        public int Price { get; set; }
    
        public virtual Author Author1 { get; set; }
        public virtual Genre Genre1 { get; set; }
    }
}

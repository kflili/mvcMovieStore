using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcMovieStore.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public int MembershipTypeID { get; set; }
        public MembershipType MembershipType { get; set; }
    }
}
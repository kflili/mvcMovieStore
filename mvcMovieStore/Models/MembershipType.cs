using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcMovieStore.Models
{
    public class MembershipType
    {
        public int ID { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}
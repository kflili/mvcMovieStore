﻿using mvcMovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcMovieStore.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}
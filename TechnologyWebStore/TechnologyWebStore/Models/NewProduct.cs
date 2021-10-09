﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnologyWebStore.Models
{
    public class NewProduct
    {
        public ProductModel Product { get; set; }

        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}

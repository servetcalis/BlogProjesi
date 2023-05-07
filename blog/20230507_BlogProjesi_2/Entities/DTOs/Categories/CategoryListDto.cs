using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.Categories
{
    public class CategoryListDto
    {
        public IList<Category> Categories { get; set; }
    }
}

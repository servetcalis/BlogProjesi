using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DTOs.Categories
{
    public class CategoryAddDto
    {
        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Boş bırakılamaz")]
        [MinLength(3, ErrorMessage = "Min. 3 karakter veri girişi yapabilirsiniz.")]
        [MaxLength(100, ErrorMessage = "Max. 3 karakter veri girişi yapabilirsiniz.")]
        public string Name { get; set; }


        [Display(Name = "Kategori Açıklaması")]
        [MinLength(5, ErrorMessage = "Min. 5 karakter veri girişi yapabilirsiniz.")]
        [MaxLength(500, ErrorMessage = "Max. 500 karakter veri girişi yapabilirsiniz.")]
        public string Description { get; set; }

        [Display(Name = "Aktif Mi?")]
        [Required(ErrorMessage = "Boş bırakılamaz")]
        public Status Status { get; set; }
    }
}

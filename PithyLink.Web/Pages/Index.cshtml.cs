﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PithyLink.Web.Attributes;

namespace PithyLink.Web.Pages
{
    public class IndexModel : PageModel
    {

        [Required]
        [IsValidUrl]
        [BindProperty]
        [Display(Name = "Url")]
        public string ShortenUrl { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
                return;

            RedirectToPage("/Index");
        }
    }
}
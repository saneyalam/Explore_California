﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Explore_California.Models
{
    public class Post
    {
        public long Id { get; set; }

        public string _key;

        public string Key {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set
            {
                _key = value;
            }
        }

        [Required]
        [StringLength(100, MinimumLength =5,
            ErrorMessage ="Title must be between 5 and 100 character long")]
        public string Title { get; set; }

        public string Author { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title must be between 5 and 100 character long")]
        public string Body { get; set; }
        public DateTime Posted { get; set; }
 
    }
}

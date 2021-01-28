﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleGenerator.Shared.Auth
{
    /// <summary>
    /// User's email and password
    /// </summary>
    public class AuthenticateRequest
    {
        /// <summary>
        /// The email of the user 
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(20, ErrorMessage = "The Email field may contain at most 20 characters.")]
        [MinLength(3, ErrorMessage = "The Email field must contain at least 3 characters.")]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// The password of the user 
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(20, ErrorMessage = "The Password field may contain at most 20 characters.")]
        [MinLength(5, ErrorMessage = "The Password field must contain at least 5 characters.")]
        public string Password { get; set; }
    }
}

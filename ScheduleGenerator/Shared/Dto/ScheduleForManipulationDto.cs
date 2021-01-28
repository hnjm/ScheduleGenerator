﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleGenerator.Shared.Dto
{
    public abstract class ScheduleForManipulationDto
    {
        [Required(AllowEmptyStrings = false)]
        [MaxLength(30, ErrorMessage = "The Name field may contain at most 30 characters.")]
        public string Name { get; set; }

        public bool Has7Days { get; set; }

    }
}

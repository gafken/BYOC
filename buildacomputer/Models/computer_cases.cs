﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class computer_cases
    {
        [Key]
        public long computer_case_id { get; set; }

        public string computer_case_name { get; set; }

        public int front_usb_connector_count { get; set; }

        public int depth_mm { get; set; }

        public int width_mm { get; set; }

        public int height_mm { get; set; }
        
        public float weight_kg { get; set; }
        
        public string color { get; set; }

        public long manufacturer_id { get; set; }

        public long motherboard_form_factor_id { get; set; }

        public long computer_case_size_id { get; set; }

        public virtual motherboard_form_factors motherboard_form_factors { get; set; }
        public virtual computer_case_sizes computer_case_sizes { get; set; }
    }
}
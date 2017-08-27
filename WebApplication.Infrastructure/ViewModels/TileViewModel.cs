﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Infrastructure.ViewModels
{
    public class TileViewModel
    {
        public string Title { get; set; }
        public int Value { get; set; }
        public string Url { get; set; }
        public string IconCssClass { get; set; }
        public string ColorCssClass { get; set; }
    }
}

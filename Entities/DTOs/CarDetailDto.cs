﻿using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto: IDto
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public int ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Descriptions { get; set; }
        
    }
}
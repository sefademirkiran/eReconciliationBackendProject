﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CurrenctAccountExcelDto
    {
        public IFormFile File {  get; set; }
        public int companyId { get; set; }
    }
}

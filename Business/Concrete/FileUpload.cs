﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FileUpload
    {
        public IFormFile file { get; set; }
        public string Post { get; set; }

    }
}

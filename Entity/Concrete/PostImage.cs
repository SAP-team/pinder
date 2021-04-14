﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class PostImage: IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }

    }
}
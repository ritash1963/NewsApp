using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class NewsDto
    {
        public string NewsType { get; set; }
        public string NewsText { get; set; }
    }
}
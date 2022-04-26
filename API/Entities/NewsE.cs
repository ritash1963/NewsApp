using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class NewsE
    {
        public int Id { get; set; }
        public string NewsType { get; set; }
        public string NewsText { get; set; }
        public int Qut { get; set; }   
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Engine.DAL.Model
{
    public class Data
    {
        [Key]
        public int ID { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public int Box { get; set; }
        public int Section { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Date { get; set; }
    }
}
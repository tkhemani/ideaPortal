using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iPortal.Models
{
    public class Idea
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ideaOriginator { get; set; }
        public string ideaOwner { get; set; }
        public string[] Tags { get; set; }

    }
}
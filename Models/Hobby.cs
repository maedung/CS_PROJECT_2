using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeltTest2.Models
{
    public class Hobby
    {
        [Key]
        public int id {get;set;}

        [Required]
        public string name {get;set;}

        [Required]
        public string description {get;set;}

        [Required]
        public int userid {get;set;}

        public User Creator {get;set;}

        public List<Enthusiast> Hobbylist {get;set;}
    }
}
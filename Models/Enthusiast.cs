using System;
using System.ComponentModel.DataAnnotations;

namespace BeltTest2.Models
{
    public class Enthusiast
    {
        [Key]
        public int id {get;set;}

        public int userid {get;set;}

        public int hobbyid {get;set;}

        public string proficiency {get;set;}

        public User User {get;set;}

        public Hobby JoinedList {get;set;}
    }
}
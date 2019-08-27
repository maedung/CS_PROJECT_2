using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeltTest2.Models
{
    public class User
    {
        [Key]
        public int id {get;set;}

        [Required]
        [MinLength(2)]
        public string firstname {get;set;}

        [Required]
        [MinLength(2)]
        public string lastname {get;set;}

        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string username {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string password {get;set;}

        [Required]
        [Compare("password")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string confirm {get;set;}

        public List<Hobby> PostedHobbies {get;set;}

        public List<Enthusiast> HobbyList {get;set;}
    }
    public class LoginUser
    {
        [Required]
        public string login_username {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string login_password {get;set;}
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Models
{
    public class TblStudentDetails
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public bool Gender { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Course { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDtTm { get; set; }
        public byte[] ImageName { get; set; }= new byte[0];
    }
}
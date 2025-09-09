namespace CMCS_Prototype.Models
{
    public class Lecturer
    {
        public int LecturerId { get; set; } // PK
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal HourlyRate { get; set; }
        public int RoleId { get; set; } // FK to Role
    }//end of class
}//end of namespace
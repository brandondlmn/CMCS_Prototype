namespace CMCS_Prototype.Models
{
    public class Claim
    {
        public int ClaimId { get; set; } // PK
        public int LecturerId { get; set; } // FK to Lecturer
        public string Month { get; set; }
        public int Year { get; set; }
        public double HoursWorked { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string CoordinatorReview { get; set; } 
        public string ManagerApproval { get; set; } 
        public int CoordinatorId { get; set; } // FK to Coordinator
        public int ManagerId { get; set; } // FK to Manager
    }//end of class
}//end of namespace
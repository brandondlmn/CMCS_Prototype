namespace CMCS_Prototype.Models
{
    public class Document
    {
        public int DocumentId { get; set; } // PK
        public int ClaimId { get; set; } // FK to Claim
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadDate { get; set; }
        public string DocumentType { get; set; } 
    }//end of class
}//end of namespace
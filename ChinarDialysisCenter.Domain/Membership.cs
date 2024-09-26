namespace ChinarDialysisCenter.Domain
{
    public class Membership
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? MobileNo { get; set; }
        public string? WhatsappNo { get; set; }
        public string? Address { get; set; }
        public string? Cnic { get; set; }
        public DateTime? MembershipDate { get; set; } 
        public int CreatedBy {  get; set; }
        public bool IsActive {  get; set; }


    }
}

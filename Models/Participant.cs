namespace LabaMeets.API.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }   
        public byte[] Stream { get; set; }    
    }
}
namespace CunDropShipping.Api.Domain;

public class DomainEntityClient
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }   
    public string Phone { get; set; }
    
    public string Address { get; set; }
    
    public DateTime RegistrationDate { get; set; }
    
}
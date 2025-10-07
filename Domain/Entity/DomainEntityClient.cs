namespace CunDropShipping.Api.Domain;

public class DomainEntityClient
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }   
    public string Phone { get; set; }
    
    public string Address { get; set; }
    
    public DateTime RegistrationDate { get; set; }

    public void ChangeFullName(string newFullName)
    {
        if (string.IsNullOrWhiteSpace(newFullName))
        {
            //error en caso tal de haber "nombres vacios"
            throw new ArgumentNullException("El nombre completo no puede estar vacío" +
                                            " o contener solo espacios.");
        }
        this.FullName = newFullName;
    }
}




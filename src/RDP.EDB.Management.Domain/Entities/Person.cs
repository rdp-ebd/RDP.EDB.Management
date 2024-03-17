namespace RDP.EDB.Management.Domain.Entities;

public class Person
{
    public string FirstName { get; private set; }
    public string? MiddleName { get; private set; }
    public string Surname { get; private set; }

    public Person(string firstName, string surname, string? middleName = null)
    {
        FirstName = firstName;
        MiddleName = middleName;
        Surname = surname;
    }
}

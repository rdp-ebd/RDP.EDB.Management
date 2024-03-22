namespace RDP.EDB.Management.Domain.Entities;

public class Person
{
    public string FirstName { get; private set; }
    public string? MiddleName { get; private set; }
    public string Surname { get; private set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Person() { }       // necessário para EF
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public Person(string firstName, string surname, string? middleName = null)
    {
        FirstName = firstName;
        MiddleName = middleName;
        Surname = surname;
    }
}

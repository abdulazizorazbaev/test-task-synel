namespace MVCApp.Entities;

public class Employee
{
    public long Id { get; set; }

    public string PayrollNumber { get; set; } = String.Empty;

    public string Forename { get; set; } = String.Empty;

    public string Surname { get; set; } = String.Empty;

    public DateOnly DateOfBirth { get; set; }

    public string Telephone { get; set; } = String.Empty;

    public string Mobile { get; set; } = String.Empty;

    public string Address { get; set; } = String.Empty;

    public string Address2 { get; set; } = String.Empty;

    public string Postcode { get; set; } = String.Empty;

    public string Email { get; set; } = String.Empty;

    public DateOnly StartDate { get; set; }
}

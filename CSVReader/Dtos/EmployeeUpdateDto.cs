using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CSVReader.Dtos;

public class EmployeeUpdateDto
{
    [Column("Id")]
    public long Id { get; set; }

    [Column("PayrollNumber")]
    public string PayrollNumber { get; set; } = String.Empty;

    [Column("Forename")]
    public string Forename { get; set; } = String.Empty;

    [Column("Surname")]
    public string Surname { get; set; } = String.Empty;

    [Column("DateOfBirth")]
    public string DateOfBirth { get; set; } = String.Empty;

    [Column("Telephone")]
    public string Telephone { get; set; } = String.Empty;

    [Column("Mobile")]
    public string Mobile { get; set; } = String.Empty;

    /*[Column("Address")]
    public string Address { get; set; } = String.Empty;

    [Column("Address2")]
    public string Address2 { get; set; } = String.Empty;

    [Column("Postcode")]
    public string Postcode { get; set; } = String.Empty;*/

    [Column("Email")]
    public string Email { get; set; } = String.Empty;

    /*[Column("StartDate")]
    public string StartDate { get; set; } = String.Empty;*/
}

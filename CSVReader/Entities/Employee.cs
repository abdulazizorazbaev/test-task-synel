using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSVReader.Entities;

[Table("Employees")]
public class Employee
{
    [Key]
    [Column("Id")]
    public long Id { get; set; }

    [Required]
    [MaxLength(30)]
    [Column("PayrollNumber")]
    public string PayrollNumber { get; set; } = String.Empty;

    [Required]
    [MaxLength(30)]
    [Column("Forename")]
    public string Forename { get; set; } = String.Empty;

    [Required]
    [MaxLength(30)]
    [Column("Surname")]
    public string Surname { get; set; } = String.Empty;

    [Required]
    [Column("DateOfBirth")]
    public string DateOfBirth { get; set; } = String.Empty;

    [Required]
    [MaxLength(10)]
    [Column("Telephone")]
    public string Telephone { get; set; } = String.Empty;

    [Required]
    [MaxLength(10)]
    [Column("Mobile")]
    public string Mobile { get; set; } = String.Empty;

    [Required]
    [MaxLength(50)]
    [Column("Address")]
    public string Address { get; set; } = String.Empty;

    [Required]
    [MaxLength(50)]
    [Column("Address2")]
    public string Address2 { get; set; } = String.Empty;

    [Required]
    [MaxLength(20)]
    [Column("Postcode")]
    public string Postcode { get; set; } = String.Empty;

    [Required]
    [MaxLength(50)]
    [Column("Email")]
    public string Email { get; set; } = String.Empty;

    [Required]
    [Column("StartDate")]
    public string StartDate { get; set; } = String.Empty;
}

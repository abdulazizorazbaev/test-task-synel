using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSVReader.Entities;

[Table("employees")]
public class Employee
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [MaxLength(30)]
    [Column("payroll_number")]
    public string PayrollNumber { get; set; } = String.Empty;

    [Required]
    [MaxLength(30)]
    [Column("forename")]
    public string Forename { get; set; } = String.Empty;

    [Required]
    [MaxLength(30)]
    [Column("surname")]
    public string Surname { get; set; } = String.Empty;

    [Required]
    [Column("date_of_birth")]
    public string DateOfBirth { get; set; } = String.Empty;

    [Required]
    [MaxLength(10)]
    [Column("telephone")]
    public string Telephone { get; set; } = String.Empty;

    [Required]
    [MaxLength(10)]
    [Column("mobile")]
    public string Mobile { get; set; } = String.Empty;

    [Required]
    [MaxLength(50)]
    [Column("address")]
    public string Address { get; set; } = String.Empty;

    [Required]
    [MaxLength(50)]
    [Column("address2")]
    public string Address2 { get; set; } = String.Empty;

    [Required]
    [MaxLength(20)]
    [Column("postcode")]
    public string Postcode { get; set; } = String.Empty;

    [Required]
    [MaxLength(50)]
    [Column("email")]
    public string Email { get; set; } = String.Empty;

    [Required]
    [Column("start_date")]
    public string StartDate { get; set; } = String.Empty;
}

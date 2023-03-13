namespace DemoMicroService.Models;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("users")]
public class User
{
    [Key]
    [Column("id")]
    public int id { get; set; }

    [Column("name")]
    public string name { get; set; }

    [Column("birthdate")]
    public DateTime BirthDate { get; set; }

    [Column("salary")]
    public double BaseSalary { get; set; }
    
}

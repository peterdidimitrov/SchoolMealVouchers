﻿namespace SchoolMealVouchers.Data.Models;

using SchoolMealVouchers.Data.Constances;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class School
{
    public School()
    {
        this.Students = new HashSet<Student>();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(ConstancesForSchool.SchoolNameMaxLength)]
    public string SchoolName { get; set; } = null!;

    [Required]
    public string SchoolAddress { get; set; } = null!;

    [Required]
    public string SchoolPhoneNumber { get; set; } = null!;


    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;

    [ForeignKey(nameof(CateringCompany))]
    public Guid CateringCompanyId { get; set; }
    public virtual CateringCompany CateringCompany { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; }
}

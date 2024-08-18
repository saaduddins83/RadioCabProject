using System;
using System.Collections.Generic;

namespace RadioCabProject.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? ContactPerson { get; set; }

    public string? Designation { get; set; }

    public string? Address { get; set; }

    public string? Mobile { get; set; }

    public string? Telephone { get; set; }

    public string? FaxNumber { get; set; }

    public string? Email { get; set; }

    public string? MembershipType { get; set; }

    public string? PaymentType { get; set; }
}

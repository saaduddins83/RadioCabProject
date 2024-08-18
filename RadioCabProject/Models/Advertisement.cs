using System;
using System.Collections.Generic;

namespace RadioCabProject.Models;

public partial class Advertisement
{
    public int AdvertisementId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Designation { get; set; }

    public string? Address { get; set; }

    public string? Mobile { get; set; }

    public string? Telephone { get; set; }

    public string? FaxNumber { get; set; }

    public string? Email { get; set; }

    public string? Description { get; set; }

    public string? PaymentType { get; set; }
}

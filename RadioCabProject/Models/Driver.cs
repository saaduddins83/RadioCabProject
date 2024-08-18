﻿using System;
using System.Collections.Generic;

namespace RadioCabProject.Models;

public partial class Driver
{
    public int DriverId { get; set; }

    public string DriverName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? ContactPerson { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Mobile { get; set; }

    public string? Telephone { get; set; }

    public string? Email { get; set; }

    public int? Experience { get; set; }

    public string? Description { get; set; }

    public string? PaymentType { get; set; }
}

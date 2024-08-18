using System;
using System.Collections.Generic;

namespace RadioCabProject.Models;

public partial class Membership
{
    public int MembershipId { get; set; }

    public string? MembershipType { get; set; }

    public decimal? MonthlyFee { get; set; }

    public decimal? QuarterlyFee { get; set; }

    public DateTime? CreatedAt { get; set; }
}

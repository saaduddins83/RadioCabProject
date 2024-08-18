using System;
using System.Collections.Generic;

namespace RadioCabProject.Models;

public partial class Feedback
{
    public int FeedbackId { get; set; }

    public string Name { get; set; } = null!;

    public string? MobileNo { get; set; }

    public string? Email { get; set; }

    public string? City { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }
}

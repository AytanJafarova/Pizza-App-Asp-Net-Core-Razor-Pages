using System;
using System.Collections.Generic;

namespace PizzaAppManagement.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string? Addresss { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

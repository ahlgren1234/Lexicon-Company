﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Shared.DTOs;

public record UserForRegistrationDto
{
    [Required(ErrorMessage = "Employee name is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
    public string Name { get; init; }

    [Required(ErrorMessage = "Age is a required field.")]
    public int Age { get; init; }

    [Required(ErrorMessage = "Position is a required field.")]
    [MaxLength(20, ErrorMessage = "Maximum length for the Position is 20 characters.")]
    public string? Position { get; init; }
    public int CompanyId { get; init; }

    [Required(ErrorMessage = "Username is required.")]
    public string? USerName { get; init; }

    [Required(ErrorMessage = "Password is required.")]
    public string? Password { get; init; }

    [Required(ErrorMessage = "Email is required.")]
    public string? Email { get; init; }

    [Required(ErrorMessage = "Role is required.")]
    public string Role { get; init; }

}

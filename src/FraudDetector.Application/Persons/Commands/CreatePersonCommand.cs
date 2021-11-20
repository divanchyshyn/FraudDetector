﻿using FraudDetector.Application.Common.Models.Commands;
using MediatR;

namespace FraudDetector.Application.Persons.Commands;

public class CreatePersonCommand : IRequest<CommandResult<Guid>>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime? DateOfBirth { get; set; }
    public string? IdentificationNumber { get; set; }
}
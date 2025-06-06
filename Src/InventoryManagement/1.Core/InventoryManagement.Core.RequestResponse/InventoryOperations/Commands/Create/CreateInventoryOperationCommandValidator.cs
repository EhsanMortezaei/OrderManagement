﻿using FluentValidation;
using Framework.ValidationMessages;
using Zamin.Extensions.Translations.Abstractions;

namespace InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Create;

public sealed class CreateInventoryOperationCommandValidator : AbstractValidator<CreateInventoryOperationCommand>
{
    public CreateInventoryOperationCommandValidator(ITranslator translator)
    {
        RuleFor(x => x.Operation)
            .NotNull()
            .WithMessage(ValidationMessages.Required);

        RuleFor(x => x.Count)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.CountGreaterThanZero);

        RuleFor(x => x.OperatorId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.OperationDate)
            .LessThanOrEqualTo(DateTime.Now)
            .WithMessage(ValidationMessages.InvalidDate);

        RuleFor(x => x.CurrentCount)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.CountGreaterThanZero);

        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);

        RuleFor(x => x.OrderId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.InventoryId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}

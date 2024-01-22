﻿using Business.Constants;
using Business.Dtos.AsyncVideo.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class AsyncVideoRequestValidator : AbstractValidator<CreateAsyncVideoRequest>
    {
        public AsyncVideoRequestValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Description).NotEmpty().MinimumLength(25).WithMessage(Messages.MustContainAtMinTwentyfiveChar);

        }
    }
}

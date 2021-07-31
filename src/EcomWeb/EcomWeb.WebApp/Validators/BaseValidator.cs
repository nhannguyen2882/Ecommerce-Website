using FluentValidation;
using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EcomWeb.WebApp.Validators
{
    /// <summary>
    /// BaseValidator.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseValidator<T> : AbstractValidator<T>
    {

    }
}

using Domain.Entities;
using FluentValidation;

namespace Service.Validators
{
    public class UsuarioValidator : AbstractValidator<User>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new System.ArgumentNullException("Can't found the object.");
                });

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("Informe seu CPF.")
                .NotNull().WithMessage("Informe seu CPF.");

            RuleFor(c => c.Aniversario)
                .NotEmpty().WithMessage("Informe sua data de aniversário.")
                .NotNull().WithMessage("Informe sua data de aniversário");

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Informe seu Nome.")
                .NotNull().WithMessage("Informe seu Nome.");
        }

    }
}

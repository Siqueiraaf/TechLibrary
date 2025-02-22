using FluentValidation;
using TechLibrary.Communication.Requests;

namespace TechLibrary.Api.UseCases.Users.Register;

public class RegisterUserValidador : AbstractValidator<RequestUserJson>
{
    public RegisterUserValidador()
    {
        RuleFor(request => request.Name).NotEmpty().WithMessage("O nome é obrigatório");
        RuleFor(request => request.Email).EmailAddress().WithMessage("O email não é valido");
        RuleFor(request => request.Password).NotEmpty().WithMessage("A senha é obrigatória");
        When(request => string.IsNullOrEmpty(request.Password) == false, () =>
        {
            RuleFor(request => request.Password).NotEmpty().WithMessage("A senha deve ter mais de 6 caracteres");
        });
    }
}

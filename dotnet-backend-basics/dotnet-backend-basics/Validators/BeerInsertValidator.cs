using dotnet_backend_basics.DTOs;
using FluentValidation;

namespace dotnet_backend_basics.Validators
{
    public class BeerInsertValidator : AbstractValidator<BeerInsertDto>
    {
        public BeerInsertValidator() {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Nombre es requerido");
            RuleFor(x => x.Name).Length(2,20).WithMessage("El nombre debe tener entre 2 y 20 caracteres");
            RuleFor(x => x.BrandID).NotNull().WithMessage("La marca es requerida");
            RuleFor(x => x.BrandID).GreaterThan(0).WithMessage("Error con el valor enviado de la marca");
            RuleFor(x => x.Alcohol).GreaterThan(0).WithMessage(x => "El {PropertyName} debe ser mayor a 0");

        }
    }
}

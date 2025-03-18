namespace TimeService.Common.Validation;

// public class TimeOnlyValidator : AbstractValidator<LocalTime>
// {
//     private readonly IPattern<string> _pattern;
//
//     public TimeOnlyValidator(IPattern<string> pattern)
//     {
//         _pattern = pattern;
//
//         RuleFor(x => x).Must(ParseInput).WithMessage("The value '{PropertyValue}' is not a valid LocalTime.");
//     }
//
//     private bool ParseInput(string value)
//     {
//         var result = _pattern.Parse(value);
//         return result.Success;
//     }
// }
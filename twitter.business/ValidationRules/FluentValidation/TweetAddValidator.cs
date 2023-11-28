using FluentValidation;
using twitter.dto.Concrete.TweetDtos;

namespace twitter.business.ValidationRules.FluentValidation
{
    internal class TweetAddValidator : AbstractValidator<TweetAddDto>
    {
        public TweetAddValidator()
        {
            RuleFor(I => I.Content).NotEmpty().WithMessage("Content requeired");
        }
    }
}
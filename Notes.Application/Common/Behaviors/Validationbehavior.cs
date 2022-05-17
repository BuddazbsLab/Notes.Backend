using FluentValidation;
using MediatR;

namespace Notes.Application.Common.Behaviors
{
    internal class Validationbehavior<TRequest, TResponse> 
        : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
        
    {

        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public Validationbehavior(IEnumerable<IValidator<TRequest>> validators) => _validators = validators;

        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var context = new ValidationContext<TRequest>(request);
            var failrules = _validators
                .Select(validator => validator.Validate(context))
                .SelectMany(result => result.Errors)
                .Where(failrules => failrules != null)
                .ToList();
            if(failrules.Count != 0)
            {
                throw new ValidationException(failrules);
            }
            return next();
        }
    }
}

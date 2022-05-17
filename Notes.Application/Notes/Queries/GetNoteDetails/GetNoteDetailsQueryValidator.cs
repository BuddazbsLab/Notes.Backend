using FluentValidation;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    internal class GetNoteDetailsQueryValidator : AbstractValidator<GetNoteDetailsQuery>
    {
        public GetNoteDetailsQueryValidator()
        {
            RuleFor(getNoteDetailsQuery => getNoteDetailsQuery.Id).NotEqual(Guid.Empty);
            RuleFor(getNoteDetailsQuery => getNoteDetailsQuery.UserId).NotEqual(Guid.Empty);
        }
    }
}

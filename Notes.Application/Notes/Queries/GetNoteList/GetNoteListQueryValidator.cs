using FluentValidation;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    internal class GetNoteListQueryValidator : AbstractValidator<GetNoteListQuery>
    {
        public GetNoteListQueryValidator()
        {
            RuleFor(getNoteList => getNoteList.UserId).NotEqual(Guid.Empty);
        }
    }
}

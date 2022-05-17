using MediatR;

namespace Notes.Application.Notes.Queries
{
    public class GetNoteDetailsQuery : IRequest<NoteDetailVm>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}

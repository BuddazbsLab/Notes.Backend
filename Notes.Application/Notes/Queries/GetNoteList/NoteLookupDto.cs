using Notes.Application.Common.Mappings;
using Notes.Domain;
using AutoMapper;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    // Класс содержит список заметок
    public class NoteLookupDto : IMapWith<Note>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        //Маппим между собой Note и NoteLookupDto
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteLookupDto>()
                           .ForMember(noteDto => noteDto.Id,
                               opt => opt.MapFrom(note => note.Id))
                           .ForMember(noteDto => noteDto.Title,
                               opt => opt.MapFrom(note => note.Title));
        }
    }
}

using AutoMapper;

namespace Notes.Application.Common.Mappings
{
    //Generic интерфейс для типа T
    //Реализация интерфейся по умолчанию
    public interface IMapWith<T>
    {
        void Mapping(Profile profile) =>
            profile.CreateMap(typeof(T), GetType());

    }
}

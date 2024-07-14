using AutoMapper;
using ProsysBack.Entities;
using ProsysBack.Models;

namespace ProsysBack.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<LessonVM, Lesson>().ReverseMap();
        CreateMap<StudentVM, Student>().ReverseMap();
        CreateMap<ExamVM, Exam>().ReverseMap();
        CreateMap<ExamDTO, Exam>().ReverseMap();
        CreateMap<PaginationRs<StudentVM>, PaginationRs<Student>>().ReverseMap();
        CreateMap<PaginationRs<LessonVM>, PaginationRs<Lesson>>().ReverseMap();
        CreateMap<PaginationRs<Exam>, PaginationRs<ExamVM>>().ReverseMap();
    }


}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProsysBack.Abstractions.Repositories;
using ProsysBack.Entities;
using ProsysBack.Models;

namespace ProsysBack.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ExamsController : ControllerBase
{
    private readonly IExamRepository _examRepository;
    private readonly IStudentRepository _studentRepository;
    private readonly ILessonRepository _lessonRepository;
    private readonly IMapper _mapper;

    public ExamsController(IExamRepository ExamRepository,IStudentRepository studentRepository,ILessonRepository lessonRepository, IMapper mapper)
    {
        _examRepository = ExamRepository;
        _studentRepository = studentRepository;
        _lessonRepository = lessonRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var Exams = await _examRepository.GetAllAsync();

        var result = _mapper.Map<IEnumerable<ExamVM>>(Exams);

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var Exam = await _examRepository.GetByIdAsync(id);

        var result = _mapper.Map<ExamVM>(Exam);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ExamDTO examDTO)
    {

        var exam = _mapper.Map<Exam>(examDTO);

        var rs = await _examRepository.CreateAsync(exam);

        return Created();
    }

    [HttpPut]
    public async Task<IActionResult> Update(ExamDTO ExamVM)
    {
        var Exam = _mapper.Map<Exam>(ExamVM);

        var result = await _examRepository.UpdateAsync(Exam);

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _examRepository.DeleteAsync(id);

        return Ok(result);
    }

}

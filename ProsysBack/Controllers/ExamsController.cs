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
    private readonly IExamRepository _ExamRepository;
    private readonly IMapper _mapper;

    public ExamsController(IExamRepository ExamRepository, IMapper mapper)
    {
        _ExamRepository = ExamRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var Exams = await _ExamRepository.GetAllAsync();

        var result = _mapper.Map<IEnumerable<ExamVM>>(Exams);

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var Exam = await _ExamRepository.GetByIdAsync(id);

        var result = _mapper.Map<ExamVM>(Exam);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ExamVM ExamVM)
    {
        var Exam = _mapper.Map<Exam>(ExamVM);

        await _ExamRepository.CreateAsync(Exam);

        return Created();
    }

    [HttpPut]
    public async Task<IActionResult> Update(ExamVM ExamVM)
    {
        var Exam = _mapper.Map<Exam>(ExamVM);

        var result = await _ExamRepository.UpdateAsync(Exam);

        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _ExamRepository.DeleteAsync(id);

        return Ok(result);
    }

}

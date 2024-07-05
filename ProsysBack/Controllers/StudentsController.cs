using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProsysBack.Abstractions.Repositories;
using ProsysBack.Entities;
using ProsysBack.Models;

namespace ProsysBack.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public StudentsController(IStudentRepository studentRepository, IMapper mapper)
    {
        _studentRepository = studentRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var students = await _studentRepository.GetAllAsync();

        var result =  _mapper.Map<IEnumerable<StudentVM>>(students);

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var student = await _studentRepository.GetByIdAsync(id);

        var result = _mapper.Map<StudentVM>(student);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(StudentVM studentVM)
    {
        var student = _mapper.Map<Student>(studentVM);

        await _studentRepository.CreateAsync(student);

        return Created();
    }

    [HttpPut]
    public async Task<IActionResult> Update(StudentVM studentVM)
    {
        var student = _mapper.Map<Student>(studentVM);

        var result = await _studentRepository.UpdateAsync(student);

        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _studentRepository.DeleteAsync(id);

        return Ok(result);
    }

    
}

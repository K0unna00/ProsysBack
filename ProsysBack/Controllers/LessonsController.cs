using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProsysBack.Abstractions.Repositories;
using ProsysBack.Entities;
using ProsysBack.Models;

namespace ProsysBack.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LessonsController : ControllerBase
{
    private readonly ILessonRepository _LessonRepository;
    private readonly IMapper _mapper;

    public LessonsController(ILessonRepository LessonRepository, IMapper mapper)
    {
        _LessonRepository = LessonRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var Lessons = await _LessonRepository.GetAllAsync();

        var result = _mapper.Map<IEnumerable<LessonVM>>(Lessons);

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var Lesson = await _LessonRepository.GetByIdAsync(id);

        var result = _mapper.Map<LessonVM>(Lesson);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(LessonVM LessonVM)
    {
        var Lesson = _mapper.Map<Lesson>(LessonVM);

        await _LessonRepository.CreateAsync(Lesson);

        return Created();
    }

    [HttpPut]
    public async Task<IActionResult> Update(LessonVM LessonVM)
    {
        var Lesson = _mapper.Map<Lesson>(LessonVM);

        var result = await _LessonRepository.UpdateAsync(Lesson);

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _LessonRepository.DeleteAsync(id);

        return Ok(result);
    }

}

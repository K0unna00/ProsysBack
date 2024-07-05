using ProsysBack.Abstractions.Repositories;
using ProsysBack.Concretes.Repositories.Base;
using ProsysBack.DAL;
using ProsysBack.Entities;

namespace ProsysBack.Concretes.Repositories;

public class LessonRepository : Repository<Lesson>, ILessonRepository
{
    public LessonRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}

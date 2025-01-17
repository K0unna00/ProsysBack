﻿using ProsysBack.Entities;

namespace ProsysBack.Models;

public class ExamVM
{
    public Guid Id { get; set; }

    public Guid LessonId { get; set; }

    public Guid StudentId { get; set; }

    public DateTime Date { get; set; }

    public decimal Grade { get; set; }

    public Lesson Lesson { get; set; }

    public Student Student { get; set; }
}

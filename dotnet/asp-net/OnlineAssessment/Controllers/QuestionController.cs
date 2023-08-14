using Microsoft.AspNetCore.Mvc;
using OnlineAssessment.Models;

namespace OnlineAssessment.Controllers;

public class QuestionController : Controller
{
    private readonly OnlineAssessmentContext _context;

    public QuestionController(OnlineAssessmentContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        List<Question> questions = _context.Questions.ToList();
        return View(questions);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Question ques)
    {
        _context.Questions.Add(new Question
        {
            question = ques.question
        });
        _context.SaveChanges();
        List<Question> questions = _context.Questions.ToList();
        return View("Index", questions);
    }

    public IActionResult Edit(int id)
    {
        Question question = _context.Questions.Find(id);
        return View(question);
    }

    [HttpPost]
    public IActionResult Edit(int id, Question ques)
    {
        Question question = _context.Questions.Find(id);
        question.question = ques.question;
        _context.SaveChanges();

        List<Question> questions = _context.Questions.ToList();
        return View("Index", questions);
    }

    public IActionResult Delete(int id)
    {
        Question question = _context.Questions.Find(id);
        _context.Questions.Remove(question);
        _context.SaveChanges();
        List<Question> questions = _context.Questions.ToList();
        return View("Index", questions);
    }
}
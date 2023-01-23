using Microsoft.AspNetCore.Mvc;

namespace GamesRental.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddTask(TaskViewModel model)
        {
            if (ModelState.IsValid)
            {
                EmployeeTask task = new EmployeeTask
                {
                    TaskDescription = model.TaskDescription,
                    TaskEnd = model.TaskEnd,
                    TaskStart = model.TaskStart,
                    TaskName = model.TaskName,
                    EmployeeId = GetUserId()
                };

                taskRepository.Create(task);
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}

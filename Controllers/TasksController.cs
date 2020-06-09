using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;


namespace ProjectCore.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index(int? projectId)

        {
            Logica.BL.Tasks tasks = new Logica.BL.Tasks();
            var ListTasks = tasks.GetTasks(projectId, null);

            var listTasksViewModel = ListTasks.Select(x => new Logica.Models.ViewModel.TasksIndexViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Details = x.Details,
                ExpirationDate = x.ExpirationDate,
                IsCompleted = x.IsCompleted,
                Effort = x.Effort,
                RemainingWork = x.RemainingWork,
                State = x.States.Name,
                Activity = x.Activities.Name,
                Priority = x.Priorities.Name,


            });

            Logica.BL.Projects projects = new Logica.BL.Projects();
            var project = projects.GetProjects(projectId, null).FirstOrDefault();
            ViewBag.project = project;

            return View(listTasksViewModel);
        }

        public IActionResult Create(int? projectId)
        {
            var tasksBindingmodel = new Logica.Models.BindingModel.TasksCreateBindingModel
            {
                ProjectId = projectId
            };

            Logica.BL.Activities activities = new Logica.BL.Activities();
            ViewBag.Activities = activities.GetActivities();

            Logica.BL.Priorities priorities = new Logica.BL.Priorities();
            ViewBag.Priorities = priorities.GetPriorities();

            Logica.BL.States states = new Logica.BL.States();
            ViewBag.States = states.GetStates();



            return View(tasksBindingmodel);



        }
        [HttpPost]
         public IActionResult Create(Logica.Models.BindingModel.TasksCreateBindingModel model)
        {

            if  (ModelState.IsValid)
            {
                Logica.BL.Tasks tasks = new Logica.BL.Tasks();
                tasks.CreateTasks(model.Title,
                    model.Details,
                    model.ExpirationDate,
                    model.IsCompleted,
                    model.Effort,
                    model.RemainingWork,
                    model.StateId,
                    model.ActivityId,
                    model.PriorityId,
                    model.ProjectId);

                return RedirectToAction("Index", new { projectId = model.ProjectId });
            }

            Logica.BL.Activities activities = new Logica.BL.Activities();
            ViewBag.Activities = activities.GetActivities();

            Logica.BL.Priorities priorities = new Logica.BL.Priorities();
            ViewBag.Priorities = priorities.GetPriorities();

            Logica.BL.States states = new Logica.BL.States();
            ViewBag.States = states.GetStates();


            return View(model);

        }  
    }
}

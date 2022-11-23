using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository_Pattern.Service;

namespace Repository_Pattern.Pages
{
    public class TasksModel : PageModel
    {
        public List<Model.Task> Tasks = new List<Model.Task>();

        private readonly ILogger<IndexModel> _logger;
        private readonly ITaskService _taskService;

        public TasksModel(ILogger<IndexModel> logger, ITaskService taskService)
        {
            _logger = logger;
            _taskService = taskService;
        }

        public void OnGet()
        {
            var tasks = _taskService.GetAll();
            foreach (Model.Task t in tasks)
            {
                Tasks.Add(t);
            }
        }
    }
}
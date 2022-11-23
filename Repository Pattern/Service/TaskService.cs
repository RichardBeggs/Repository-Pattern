using Repository_Pattern.Data;

namespace Repository_Pattern.Service
{
    public class TaskService : ITaskService
    {
        private readonly ITaskDataService _TaskDataService;

        public TaskService(ITaskDataService taskDataService)
        {
            _TaskDataService = taskDataService;
        }

        public void Add(Task task)
        {
            throw new NotImplementedException();
        }

        public Task Delete()
        {
            throw new NotImplementedException();
        }

        public Task<Task> Get()
        {
            throw new NotImplementedException();
        }

        public List<Model.Task> GetAll()
        {
            return _TaskDataService.GetAll();
        }

        public void Update(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
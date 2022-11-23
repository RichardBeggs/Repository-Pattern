namespace Repository_Pattern.Data
{
    using Repository_Pattern.Context;
    using Repository_Pattern.Model;
    using System.Collections.Generic;

    public class TaskDataService : ITaskDataService
    {
        private readonly TaskContext TaskContext;
        public TaskDataService(TaskContext taskContext)
        {
            TaskContext = taskContext;
        }

        public void Add(Model.Task task) 
        {
            TaskContext.Tasks.Add(task);
            TaskContext.SaveChanges();
        }

        public List<Task> GetAll()
        {
           return TaskContext.Tasks.Where(x => x.IsVisible).ToList();
        }

        public void Remove(Task task)
        {
            throw new NotImplementedException();
        }

        public void Update(Task task)
        {
            throw new NotImplementedException();
        }
    }
}

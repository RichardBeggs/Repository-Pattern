namespace Repository_Pattern.Service
{
    public interface ITaskService
    {
        void Add(Task task);

        Task<Task> Get();

        List<Model.Task> GetAll();

        Task Delete();

        void Update(Task task);
    }
}
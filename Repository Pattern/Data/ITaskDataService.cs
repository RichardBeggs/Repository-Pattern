namespace Repository_Pattern.Data
{
    public interface ITaskDataService
    {
        public void Add(Model.Task task);
        public void Remove(Model.Task task);
        public void Update(Model.Task task);
        public List<Model.Task> GetAll();
    }
}

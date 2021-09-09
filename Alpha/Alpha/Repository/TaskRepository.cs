using System.Collections.Generic;

namespace Alpha.Repository
{
    public class TaskRepository : IRepository<ProcessTask>
    {
        protected readonly AppContext Context;
        
        public IEnumerable<ProcessTask> Get()
        {
            return Context.ProcessTasks;
        }

        public ProcessTask Get(int id)
        {
            return Context.ProcessTasks.Find(id);
        }

        public void Create(ProcessTask item)
        {
            Context.ProcessTasks.Add(item);
            Context.SaveChanges();
        }

        public void Update(ProcessTask item)
        {
            var current = Get(item.Id);
            current.State = item.State;
            Context.ProcessTasks.Update(current);
            Context.SaveChanges();
        }

        public ProcessTask Delete(int id)
        {
            var current = Get(id);
            if (current != null)
            {
                Context.ProcessTasks.Remove(current);
                Context.SaveChanges();
            }
            return current;
        }

        public TaskRepository(AppContext context)
        {
            Context = context;
        }
    }
}
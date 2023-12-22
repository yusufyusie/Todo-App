using Contracts;
using Entity;
using Entity.Models;

namespace Repository
{
    public class TaskRepository : ITodo
    {
        private readonly TaskDbContext _dbContext;
        public TaskRepository(TaskDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public List<Todo> AddAllTasks(Todo tod1)
        //{
        //    _dbContext.Todos.Add(tod1);
        //    _dbContext.SaveChanges();
        //    return {
        //        tod1.id,

        //    }
        //}

        public int CreateTask(Todo todo)
        {
            _dbContext.Todos.Add(todo);
            _dbContext.SaveChanges();
            return todo.id;
        }

        public int DeleteTask(int id)
        {
            var todo = _dbContext.Todos.FirstOrDefault(m =>m.id ==id);
            if (todo != null)
            {
                _dbContext.Todos.Remove(todo);
                _dbContext.SaveChanges();
            }
            return id;

        }

        public List<Todo> GetTasks()
        {
            return _dbContext.Todos.ToList();
        }
    }
}

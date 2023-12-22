using Entity.Models;

namespace Contracts
{
    public interface ITodo
    {
        public int CreateTask(Todo todo);
        public List<Todo> GetTasks();
        public int DeleteTask(int id);
        //public List<Todo> AddAllTasks(Todo tod1);

    }
}

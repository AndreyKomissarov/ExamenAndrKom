using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TaskList
    {
        public string name { get; set; }
        public List<Task> tasks { get; set; }
        /// <summary>
        /// Возвращает имя списка задач
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// Добавляет задачу в список задач
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        /// <summary>
        /// Удаляет задачу из списка задач
        /// </summary>
        /// <param name="task"></param>
        public void Remove(Task task)
        {
            tasks.Remove(task);
        }
        /// <summary>
        /// Возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks()
        {
            return tasks;
        }
    }
}

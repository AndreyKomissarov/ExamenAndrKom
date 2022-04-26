using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Application
    {
        private static Application application { get; set; }
        public List<TaskList> taskLists { get; set; }
 

        /// <summary>
        /// Возвращает ссылку на экземпляр приложения
        /// </summary>
        /// <returns></returns>
        public Application GetApplication()
        {
            return application;
        }
        /// <summary>
        /// Создает список задач и добавляет его в taskLists
        /// </summary>
        /// <param name="name"></param>
        public void CreateTaskList(string name)
        {
            taskLists.Add(new TaskList());
        }
        /*public Application GetTaskListNames()
        {
            return TaskList.name;
        }
        */
    }
}

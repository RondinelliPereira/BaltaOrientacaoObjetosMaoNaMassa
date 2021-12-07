using BaltaOrientacaoObjetosMaoNaMassa.NotificationContext;
using BaltaOrientacaoObjetosMaoNaMassa.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaOrientacaoObjetosMaoNaMassa.ContentContext
{

    public class CareerItem : Base
    {
        public CareerItem(int ordem, string title, string description, Course course)
        {
            if (course == null)
            {
                AddNotification(new Notification("Course", "Curso invalido"));  
            }
           
            Order = ordem;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}

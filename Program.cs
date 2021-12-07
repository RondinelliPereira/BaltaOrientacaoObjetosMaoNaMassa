using BaltaOrientacaoObjetosMaoNaMassa.ContentContext;
using BaltaOrientacaoObjetosMaoNaMassa.SubscriptionContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BaltaOrientacaoObjetosMaoNaMassa
{
    public class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "Orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "A linguagem C Sharp"));
            articles.Add(new Article("Artigo sobre .NET", "O mundo .NET"));

            foreach (var article in articles)
            {
                //Console.WriteLine(article.Id);
                //Console.WriteLine(article.Title);
                //Console.WriteLine(article.Url);
                
            }

            var courses = new List<Course>();   
            var courseOOP = new Course("Fundamentos OOP", "fundamento-OOP");
            var courseCSharp = new Course("C#", "fundamento-CSharo");
            var courseAspNet = new Course("Fundamentos .NET", "fundamento-ASPNET");

            courses.Add(courseOOP);
            courses.Add(courseCSharp);
            courses.Add(courseAspNet);




            var careers = new List<Career>();   
            var careerDotnet = new Career("Especialista .NET", "especialista em .NET");
            var careerItem2 = new CareerItem(2, "OOP", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCSharp);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x=>x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);
                    Console.WriteLine(item.Course?.DurationInMinutes);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.CreateSubscription(payPalSubscription);
            }

        }
    }
}

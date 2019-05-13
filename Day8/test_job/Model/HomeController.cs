using System;
using System.Collections.Generic;
using Hangfire;

namespace testjob.Model
{
    public class HomeController
    {
        // public string Index()
        // {
        //     // Scheduling Background Job
        //     BackgroundJob.Schedule(
        //         () => Console.WriteLine("================Delayed by 5 second"),
        //         TimeSpan.FromSeconds(5)
        //     );
        //     BackgroundJob.Schedule(
        //         () => Console.WriteLine("================Delayed by 1 min"),
        //         TimeSpan.FromMinutes(1)
        //     );
        //     BackgroundJob.Schedule(
        //         () => Console.WriteLine("================Delayed by 2 min"),
        //         TimeSpan.FromMinutes(2)
        //     );
        //     return "Hello from MVC";
        // }

        public string Index()
        {
            IList<int> time = new List<int>() { 5, 60, 80 };
            for (int i = 0; i < time.Count; i++)
            {
                BackgroundJob.Schedule(
                    () => Console.WriteLine($"================Delayed by {time[i]} seconds"), TimeSpan.FromSeconds(time[i])
                );
            };
            return "Hello from MVC";
        }
    }
}
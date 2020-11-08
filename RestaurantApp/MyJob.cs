using System;
using System.Threading.Tasks;
using Quartz;

namespace RestaurantApp
{
    public class MyJob: IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            FileManager fileManager = new FileManager();
            fileManager.CreateHtmlFile();
            await EmailService.SendEmailAsync();
        }
    }
}
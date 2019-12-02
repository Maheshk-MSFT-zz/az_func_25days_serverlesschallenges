using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Day1
{
    public static class RandomNoHttpTriggerDay1
    {
        [FunctionName("RandomNoHttpTriggerDay1")]
        public static string Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req)
        {
            string[] availaleOptions = new string[] { "Nun", "Gimmel", "Hay", "Shin" };
            var getRandom = new Random();
            var index = getRandom.Next(availaleOptions.Length);
            string myreturnval = availaleOptions[index];
            return "Dreidel returns -" + myreturnval;
        }
    }
}

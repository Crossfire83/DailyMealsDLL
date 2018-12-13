using Newtonsoft.Json;
using System;
using WSDailyMeals.Algorithm;

namespace DailyMeals
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalKCal = double.Parse(args[0]);

            double KCalProt = totalKCal * .15;
            double KCalCarbs = totalKCal * .55;
            double KCalLipid = totalKCal * .3;

            Core c = new Core(KCalLipid, KCalCarbs, KCalProt);
            string result = JsonConvert.SerializeObject(c.result);
            Console.Write(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldTimeZone
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime nDate = DateTime.UtcNow;
            //nDate = nDate.AddHours(6);
            //Console.WriteLine("Current date:" + nDate.ToString());
            //Console.ReadKey();
            ReadOnlyCollection<TimeZoneInfo> tzcollection;
            tzcollection = TimeZoneInfo.GetSystemTimeZones();
            foreach (TimeZoneInfo timezone in tzcollection)
                Console.WriteLine("{0}:{1}", timezone.Id ,timezone.DisplayName);
            Console.ReadKey();
        }
    }
}

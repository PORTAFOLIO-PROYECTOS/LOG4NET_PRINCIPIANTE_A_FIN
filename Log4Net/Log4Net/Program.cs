using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Log4Net
{
    class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();// log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            divide();
            Console.ReadLine();
            void divide()
            {
                try
                {
                    var i = 0;
                    var a = 5 / i;
                }
                catch (DivideByZeroException ex)
                {
                    log.Error("división entro 0", ex);
                }

            }
        }

    }
}

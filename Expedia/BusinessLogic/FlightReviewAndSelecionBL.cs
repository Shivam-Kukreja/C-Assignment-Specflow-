using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expedia.CommonUtilities;
using Expedia.ObjectRepo;
using Expedia.PageLogic;
using Expedia.TestBase;
using NUnit.Framework;

namespace Expedia.BusinessLogic
{
    class FlightReviewAndSelecionBL : Driver
    {
        CommonFunctionalities common1 = new CommonFunctionalities();
        FlightReviewAndSelection obj1 = new FlightReviewAndSelection();
        private static double fare = 0.00f;

        public bool check_summary()
        {
            try
            {
                String airport1 = "Luqa, Malta (MLA)";
                Assert.AreEqual(common1.get_text(obj1.get_departure1()), airport1);
                return true;
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
               return false;
            }
        }

        public bool pick_flight()
        {
            try
            {
                common1.switchwindow();
                common1.wait();
                FlightReviewAndSelecionBL.fare = common1.getFare1(obj1.slect_fligh1());

                common1.press(obj1.slect_fligh1());
                common1.wait();
                common1.switchwindow();
                common1.press(obj1.slect_fligh2());
                common1.switchwindow();
                common1.wait();
                common1.press(obj1.slect_fligh3());
                return true;
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
        }

        public bool Assert_Total(String num)
        {
            common1.wait();
            double total = FlightReviewAndSelecionBL.fare * double.Parse(num);
            common1.SwitchTabs();
            common1.wait();
            if (total == common1.getFare(obj1.get_totalFare()))
                return true;
           else
                return false;
        }

    }
}

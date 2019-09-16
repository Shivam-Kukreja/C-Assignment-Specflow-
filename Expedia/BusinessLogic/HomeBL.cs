using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expedia.CommonUtilities;
using Expedia.ObjectRepo;
using Expedia.TestBase;

namespace Expedia.BusinessLogic
{
    class HomeBL: Driver
    {
        CommonFunctionalities common;
        HomePL obj;

        public bool check_Homepage()
        {
            common = new CommonFunctionalities();
            invoke_Driver();
            common.go_to("https://www.expedia.com");
            if (common.check_title("Expedia Travel: Search Hotels, Cheap Flights, Car Rentals & Vacations"))
                return true;
            else
                return false;

        }
        public void click_flight()
        {
            try
            {
                obj = new HomePL();
                common.press(obj.Get_FLight_Btn());
                common.press(obj.Get_Multicity());
            }

            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        public void built_Itenary(String airport1,String airport2,String airport3,String date1,String date2,String date3, String pax)
        {
            try
            {
                common.press(obj.FlyingFrom_Leg1());
                common.send_keys(obj.FlyingFrom_Leg1(), airport1);
                common.press(obj.FlyingTo_Leg1());
                common.send_keys(obj.FlyingTo_Leg1(), airport2);
                

                common.send_keys(obj.flight1_date(), date1);
                common.press(obj.get_pax());
                for(int i = 0; i < int.Parse(pax)-1; i++)
                {
                    common.press(obj.increase_pax());
                }

                common.press(obj.FlyingFrom_Leg2());
                common.send_keys(obj.FlyingFrom_Leg2(), airport2);
                common.press(obj.FlyingTo_Leg2());
                common.send_keys(obj.FlyingTo_Leg2(), airport3);
                common.send_keys(obj.flight2_date(), date2);

                common.press(obj.Get_Add_anotherlight());

                common.press(obj.FlyingFrom_Leg3());
                common.send_keys(obj.FlyingFrom_Leg3(), airport3);
                common.press(obj.FlyingTo_Leg3());
                common.send_keys(obj.FlyingTo_Leg3(), airport1);
                common.send_keys(obj.flight3_date(), date3);

                common.press(obj.Search_btn());

                //return true;
            }

            catch(Exception e)
            {
                Console.Write(e.Message);
                //return false;
            }
        }
    }
}

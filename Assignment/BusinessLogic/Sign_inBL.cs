using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.CommonUtilities;
using Assignment.Pages;
using Assignment.TestBase;

namespace Assignment.BusinessLogic
{
    class Sign_inBL : Driver
    {
        CommonFunctionalities Common;
        Sign_inPL obj;
        public bool check_HomePage()
        {
            Common = new CommonFunctionalities();
            invoke_Driver();
            Common.go_to("http://automationpractice.com/index.php");
            if (Common.check_title("My Store"))
                return true;
            else
                return false;
            
        }
        public bool Click_SignIn()
        {
            try
            {
                obj = new Sign_inPL();
                Common.press(obj.Get_Signin_Btn());
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
        }
        public bool keys(String usr_name,String password)
        {
            try
            {
                Common.send_keys(obj.Email_Input(), usr_name);
                Common.send_keys(obj.Password_Input(), password);
                return true;
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
                return false;
            }

        }
        public bool Login_Btn()
        {
            try
            {
                Common.press(obj.SignIn_Button());
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
        }
        public String get_error()
        {
            return Common.get_msg(obj.Errormessage_Field());   
        }
        public void close_browser()
        {
            Common.quit();
        }
    }
}

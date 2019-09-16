using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace ReqRes.Business_Logic
{
    class ScenarioLogic
    {
        public  RestClient client;
        public RestRequest request;
        public IRestResponse response;

        public void invoke()
        {
            client = new RestClient("https://reqres.in");
        }

        public void Registration(String usrnme, String passwd)
        {
            String request_address = "/api/register";
            request = new RestRequest(request_address, Method.POST);
            request.RequestFormat= DataFormat.Json;
            request.AddParameter("email", usrnme);
            request.AddParameter("password", passwd);
        }

        public bool check_registration()
        {
            response = client.Execute(request);
            int response_code = (int)response.StatusCode;
            if (response_code == 200)
            {
                return true;
            }
            else if (response_code == 400)
            {
                return false;
            }
            else
                return false;
        }

        public bool token_generation()
        {
            var variable= JObject.Parse(response.Content);
            var token_code=(string)variable.SelectToken("token");

            if (token_code != null)
                return true;
            else
                return false;
        }

        public void get_users()
        {
            String request_address = "/api/users";
            request = new RestRequest(request_address, Method.GET);
            response = client.Execute(request);
        }

        public bool check_responseNusers()
        {
            if ((int)response.StatusCode == 200)
            {
                var variable = JObject.Parse(response.Content);
                var list= variable.SelectToken("data");
                if (list != null)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }



    }
}

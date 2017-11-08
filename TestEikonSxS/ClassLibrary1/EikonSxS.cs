using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EikonSxSClassLibrary
{
    public class EikonSxS
    {
        public int PORT { get; set; } = 9000;
        public bool ISVALIDPORT { get; set; } = false;
        public string URL_PING { get; set; } = "http://127.0.0.1:9000/ping";
        public string URL_SXS { get; set; } = "http://127.0.0.1:9000/sxs/v1";
        public string PRODUCT_ID { get; set; } = "";
        public string APIKEY { get; set; } = "";

        
        public string SESSIONTOKEN { get; set; } = "";
        public bool ISHANDSHAKESUCCESS  { get; set; } = false;

        public List<EikonApp> EIKONAPP { get; set; } = new List<EikonApp>();


        private RestClient restClient = new RestClient();

        public EikonSxS()
        {

        }


        public string DoPingTest()
        {
            string strResponse = "";

            restClient.URI = URL_PING;
            restClient.httpMethod = httpMethod.GET;

            strResponse = restClient.GetRequest();

            return strResponse;

        }

        public string DoHandshake()
        {
            string strResponse = string.Empty;

            restClient.httpMethod = httpMethod.POST;
            restClient.URI = URL_SXS;            
                        
            JsonHandshake jHandshake = new JsonHandshake(PRODUCT_ID, APIKEY);            
            string strPostData = JsonConvert.SerializeObject(jHandshake);
            
            strResponse = restClient.PostRequest(strPostData);

            // Using Newtonsoft.Json library to do JSON Deserialization Object
            try
            {
                var myObject = JsonConvert.DeserializeObject<dynamic>(strResponse);
                
                if (myObject.isSuccess == true)
                {
                    SESSIONTOKEN = myObject.sessionToken;
                    ISHANDSHAKESUCCESS = true;              

                }
                else
                {
                    SESSIONTOKEN = "";
                    ISHANDSHAKESUCCESS = false;
                    DebugOutput("ERROR");                    
                }

            }
            catch (Exception ex)
            {

                strResponse = ex.Message.ToString();
            }


            return strResponse;
        }


        public string DoLaunchApp(string appName)
        {
            string strResponse = string.Empty;

            restClient.httpMethod = httpMethod.POST;
            restClient.URI = URL_SXS;

            //JsonLaunchAppSimple jLaunchApp = new JsonLaunchAppSimple();
            JsonLaunchApp jLaunchApp = new JsonLaunchApp();
            jLaunchApp.appId = appName;
            jLaunchApp.sessionToken = SESSIONTOKEN;
            jLaunchApp.context.entities.Add(new JsonEntities("TRI.N"));
            jLaunchApp.context.entities.Add(new JsonEntities("MSFT.O"));

            string strPostData = JsonConvert.SerializeObject(jLaunchApp);

            DebugOutput(strPostData);            

            strResponse = restClient.PostRequest(strPostData);

            // Using Newtonsoft.Json library to do JSON Deserialization Object
            try
            {
                var myObject = JsonConvert.DeserializeObject<dynamic>(strResponse);

                if (myObject.isSuccess == true)
                {
                    DebugOutput("instanceID: " + myObject.instanceId);
                    EIKONAPP.Add(new EikonApp(myObject.instanceId.ToString(), jLaunchApp));
                }
                else
                {
                    DebugOutput("ERROR LAUNCHING APP");
                }

            }
            catch (Exception ex)
            {

                strResponse = ex.Message.ToString();
            }

            return strResponse;
        }


        public void DebugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }

        }


    }

}

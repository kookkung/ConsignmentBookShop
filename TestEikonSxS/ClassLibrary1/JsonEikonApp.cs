using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* POST to launch app
{
    "command": "launch",
    "sessionToken": "<session token returned from handshake>",
    "appId": "Quote Object"
}

{
    "command": "launch",
    "sessionToken": "<session token returned from handshake>",
    "appId": "News",
    "context": {
       "entities": [{
           "RIC": "TRI.TO"
           }]
    }
}


    */

namespace EikonSxSClassLibrary
{

    public class JsonApp
    {
        public string sessionToken { get; set; } = "";
        public string appId { get; set; } = "";
        public JsonContext context { get; set; } = new JsonContext();


        public override string ToString()
        {
            return appId;
        }

    }

    public class JsonLaunchApp : JsonApp
    {
        public string command { get; } = "launch";

    }

    public class JsonContext
    {
        public List<JsonEntities> entities { get; set; } = new List<JsonEntities>();
    }


    public class JsonEntities
    {
        public string RIC { get; set; } = "";

        public JsonEntities(string strInput = "")
        {
            RIC = strInput;
        }

    }


    public class JsonHandshake
    {
        public string command { get; } = "handshake";
        public string productId { get; set; } = "";
        public string apiKey { get; set; } = "";

        public JsonHandshake(string pId = "", string aKey = "")
        {
            productId = pId;
            apiKey = aKey;
        }
    }


}

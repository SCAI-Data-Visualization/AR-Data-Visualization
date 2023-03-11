using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using System;

namespace jsonhelpernamespace
{
    [System.Serializable]
    public class JsonHelper
    {
        public List<List<int>> locations;
        public string size;
        public string task;
        public string color; //kinda lazy, dont wanna deal with defining color values in JSON - Logan
        public int start;
        public int goal;

        static public void coordinateReader(JsonHelper json_values)
        {
            var locations  = json_values.locations;
            foreach (var innerList in locations)
            {
                Debug.Log("Coordinates are: [" + innerList[0] + ", " + innerList[1] + "]\n");
            }
        }
        public JsonHelper CreateFromJSON(string JSONString)
        {
            //Debug.Log(JSONString);
            JsonHelper json_values = JsonConvert.DeserializeObject<JsonHelper>(JSONString);
            //coordinateReader(json_values);
            return json_values;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace jsonhelpernamespace
{
    [System.Serializable]
    public class JsonHelper
    {
        public int[] location;
        public string shape;
        public int size;
        public string color; //kinda lazy, dont wanna deal with defining color values in JSON - Logan


        public JsonHelper CreateFromJSON(string JSONString)
        {
            return JsonUtility.FromJson<JsonHelper>(JSONString);
        }
    }
}
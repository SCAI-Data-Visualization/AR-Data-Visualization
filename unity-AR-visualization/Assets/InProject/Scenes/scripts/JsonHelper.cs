using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace jsonhelpernamespace
{
    [System.Serializable]
    public class JsonHelper
    {
        /*TODO: Change these to match the ones in actual json files*/
        public string size;
        public int number;
        public string modality;


        public JsonHelper CreateFromJSON(string JSONString)
        {
            return JsonUtility.FromJson<JsonHelper>(JSONString);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace jsonhelpernamespace
{
    //[System.Serializable]
    public class JsonLoader : MonoBehaviour
    {
        /*TODO: Change these to match the ones in actual json files*/
        public string size;
        public int number;
        public string modality;
        public JsonHelper jsonHelper;

        public void readJSON(string JSONString)
        {
            JsonHelper parsedFile = new JsonHelper();
  
            string jsonString = File.ReadAllText(JSONString);
            
            jsonHelper = parsedFile.CreateFromJSON(jsonString);
            if(jsonHelper == null)
            {
                Debug.LogError("No Json loaded");
            }
        }
    }
}
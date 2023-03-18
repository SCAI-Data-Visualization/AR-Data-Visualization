using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace jsonhelpernamespace
{
    //[System.Serializable]
    public class JsonLoader : MonoBehaviour
    {
        public JsonHelper jsonHelper;

        public void level_randomizer()
        {
            int first_test = Random.Range(0, 3);
            SceneBuilderController.level_list = new List<int> { };
            SceneBuilderController.level_list.Add(first_test);
            SceneBuilderController.level_num = 0;
            while (SceneBuilderController.level_list.Count < 3)
            {
                int num = Random.Range(0, 3);
                if (!SceneBuilderController.level_list.Contains(num))
                {
                    SceneBuilderController.level_list.Add(num);
                }
            }
        }
        public void readJSON()
        {
            JsonHelper parsedFile = new JsonHelper();
            string pathString = "Assets/InProject/Scenes/scripts/jsonfiles/test_click" + SceneBuilderController.level_list[SceneBuilderController.level_num] + ".json";
            Debug.Log("File path loaded is " + pathString);
            string jsonString = File.ReadAllText(pathString);
            
            jsonHelper = parsedFile.CreateFromJSON(jsonString);
            if(jsonHelper == null)
            {
                Debug.LogError("No Json loaded");
            } else
            {
                SceneBuilderController.jsonHelper = jsonHelper;
            }
        }
    }
}
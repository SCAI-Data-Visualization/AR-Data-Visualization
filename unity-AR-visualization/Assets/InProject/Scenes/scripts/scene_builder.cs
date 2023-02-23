using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace jsonhelpernamespace
{
    public class scene_builder : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        public void task_generate(JsonHelper sceneElements, GameObject prefab)
        {
            //UnityEngine.Debug.Log(sceneElements.size); //TODO: Delete log, only to show that flow from load -> start works
/*            int dot_num = sceneElements.number;
            UnityEngine.Debug.Log(dot_num);
            GameObject obj = Instantiate(prefab);*/
      
        /*    var prefab = Resources.Load<GameObject>("Assets/InProject/MRTK/Prefabs/button_parent.prefab");
            GameObject button = Instantiate(prefab);*/
       
/*            for(int i = 0; i < dot_num; i++)
            {
                
                
            }*/
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

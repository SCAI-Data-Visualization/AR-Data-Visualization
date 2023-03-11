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
            JsonHelper.coordinateReader(sceneElements);
            //make some objects
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

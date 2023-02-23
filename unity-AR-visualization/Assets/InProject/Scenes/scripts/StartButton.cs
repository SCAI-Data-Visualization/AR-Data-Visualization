using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace jsonhelpernamespace
{
    public class StartButton : MonoBehaviour
    {
        // Start is called before the first frame update
        public LoadingObjectController LoadObject; 
        public GameObject prefab;
        void Start()
        {

        }

        public void SceneBuilder()
        {
            LoadObject.LoadingObject.SetActive(true);
            JsonHelper sceneElements = GameObject.Find("Load_File").GetComponent<JsonLoader>().jsonHelper;
            SceneManager.LoadScene("task_scene");
            scene_builder builder = new scene_builder();
            builder.task_generate(sceneElements, prefab);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

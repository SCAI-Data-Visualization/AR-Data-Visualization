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

        public void SceneBuilder(status status)
        {
            if (status.loaded_status == true)
            {
                LoadObject.LoadingObject.SetActive(true);
                JsonHelper sceneElements = GameObject.Find("Load_File").GetComponent<JsonLoader>().jsonHelper;
                SceneBuilderController.gameObject = prefab;
                SceneManager.LoadScene("task_scene");
            }
            else
            {
                return;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

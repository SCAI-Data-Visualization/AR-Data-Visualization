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
        public GameObject prefab_click;
        public GameObject prefab_drag;
        public GameObject prefab_drag_goal;
        public GameObject prefab_zoom;
        public GameObject prefab_zoom_goal;
        void Start()
        {
            SceneBuilderController.panTask = false;
            SceneBuilderController.total_time = 0;
        }

        public void SceneBuilder(status status)
        {
            LoadObject.LoadingObject.SetActive(true);
            if (status.loaded_status == true)
            {
                JsonHelper sceneElements = GameObject.Find("Load_File").GetComponent<JsonLoader>().jsonHelper;
            }
            else if (SceneBuilderController.panTask)
            {
                Debug.Log("PAN MODE");
                SceneManager.LoadScene("pan_scene");
                return;
            }
            else if (SceneBuilderController.oneJSON)
            {
                JsonHelper sceneElements = GameObject.Find("RadialSet_Interaction").GetComponent<JsonLoader>().jsonHelper;
            }
            else
            {
                return;
            }
            SceneBuilderController.prefab_click = prefab_click;
            SceneBuilderController.prefab_drag = prefab_drag;
            SceneBuilderController.prefab_drag_goal = prefab_drag_goal;
            SceneBuilderController.prefab_zoom = prefab_zoom;
            SceneBuilderController.prefab_zoom_goal = prefab_zoom_goal;
            SceneManager.LoadSceneAsync("task_scene", LoadSceneMode.Single);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

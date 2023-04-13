using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;
using UnityEngine.EventSystems;
//using System.Diagnostics;

namespace jsonhelpernamespace
{
    public class scene_builder : MonoBehaviour
    {
        public JsonHelper sceneElements;
        public GameObject prefab;

        // Start is called before the first frame update
        void Start()
        {
            sceneElements = SceneBuilderController.jsonHelper;
            if (sceneElements.task == "click")
            {
                prefab = SceneBuilderController.prefab_click;
                GameObject SpawnPoint = GameObject.Find("SpawnPoint");
                Transform ParentTransform = SpawnPoint.transform;
                var location = sceneElements.locations;
                List<GameObject> gameObjects = new List<GameObject>();
                for (int i = 0; i < location.Count; i++)
                {
                    GameObject temp = prefab;
                    gameObjects.Add(temp);
                    gameObjects[i] = Instantiate(gameObjects[i]);
                    gameObjects[i].transform.SetParent(ParentTransform);
                    gameObjects[i].transform.localPosition = new Vector3(location[i][0] * 100, location[i][1] * 100, 5);
                }
            }
            else if (sceneElements.task == "drag") {
                GameObject SpawnPoint = GameObject.Find("SpawnPoint");
                Transform ParentTransform = SpawnPoint.transform;
                var location = sceneElements.locations;
                List<GameObject> gameObjects = new List<GameObject>();
                GameObject temp = new GameObject();
                for (int i = 0; i < location.Count; i++)
                {
                    if(i != sceneElements.goal)
                    {
                        temp = SceneBuilderController.prefab_drag;
                        gameObjects.Add(temp);
                        gameObjects[i] = Instantiate(gameObjects[i]);
                        gameObjects[i].transform.SetParent(ParentTransform);
                        gameObjects[i].transform.localPosition = new Vector3(location[i][0] * 100, location[i][1] * 100, 5);

                    }
                    else
                    {
                        temp = SceneBuilderController.prefab_drag_goal;
                        gameObjects.Add(temp);
                        gameObjects[i] = Instantiate(gameObjects[i]);
                        gameObjects[i].transform.SetParent(ParentTransform);
                        gameObjects[i].transform.localScale = new Vector3(1000, 1000, 1000);
                        gameObjects[i].transform.localPosition = new Vector3(location[i][0] * 100, location[i][1] * 100, 5);
                    }
                }
            }
            else if (sceneElements.task == "zoom")
            {
                prefab = SceneBuilderController.prefab_zoom;
                GameObject SpawnPoint = GameObject.Find("SpawnPoint");
                Transform ParentTransform = SpawnPoint.transform;
                var location = sceneElements.locations;
                GameObject zoomableObj = prefab;
                zoomableObj = Instantiate(zoomableObj);
                zoomableObj.transform.SetParent(ParentTransform);
                zoomableObj.transform.localPosition = new Vector3(location[0][0] * 100, location[0][1] * 100, 50);
                zoomableObj.transform.localScale = new Vector3(1000, 1000, 500);

                GameObject zoom_goal = SceneBuilderController.prefab_zoom_goal;
                zoom_goal = Instantiate(zoom_goal);
                zoom_goal.transform.SetParent(ParentTransform);
                zoom_goal.transform.localPosition = new Vector3((location[0][0] - 1) * 100, (location[0][1] + 1) * 100, 75);
                zoom_goal.transform.localRotation = Quaternion.Euler(0f, 0f, 270f);


                GameObject zoom_goal_2 = SceneBuilderController.prefab_zoom_goal;
                zoom_goal_2 = Instantiate(zoom_goal_2);
                zoom_goal_2.transform.SetParent(ParentTransform);
                zoom_goal_2.transform.localPosition = new Vector3((location[0][0] + 1) * 100, (location[0][1] - 1) * 100, 75);
                zoom_goal_2.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
                /*zoom_goal.transform.localScale = new Vector3(1000, 1000, 1000);*/
            }
            JsonHelper.coordinateReader(sceneElements);
        }

        void Update()
        {

        }
    }
}

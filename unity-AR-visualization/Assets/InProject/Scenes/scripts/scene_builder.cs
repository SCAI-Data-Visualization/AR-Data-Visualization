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
            JsonHelper.coordinateReader(sceneElements);
        }

        void Update()
        {

        }
    }
}

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
                prefab = SceneBuilderController.prefab;
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
            else if (sceneElements.task == "drag")
            {
                prefab = SceneBuilderController.prefab;
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
                    //Button.transform.localPosition = new Vector3(location[i][0] * 100, location[i][1] * 100, 5);
                    gameObjects[i].transform.localPosition = new Vector3(location[i][0] * 100, location[i][1] * 100, 5);
                    Debug.Log("Im here!");
                }
            }


            JsonHelper.coordinateReader(sceneElements);
        }


        void Update()
        {

        }
    }
}

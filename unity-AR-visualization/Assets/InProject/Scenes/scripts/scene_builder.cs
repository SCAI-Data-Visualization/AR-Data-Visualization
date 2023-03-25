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
            Debug.Log("STARTING BUILD");
            sceneElements = SceneBuilderController.jsonHelper; 
            prefab = SceneBuilderController.prefab;
            GameObject SpawnPoint = GameObject.Find("SpawnPoint");
            GameObject Button = Instantiate(prefab);
            Transform ParentTransform = SpawnPoint.transform;
            Button.transform.SetParent(ParentTransform);
            var location = sceneElements.locations;
            Button.transform.localPosition = new Vector3(location[0][0] * 100, location[0][1] * 100, 5);
            
            JsonHelper.coordinateReader(sceneElements);
        }


        void Update()
        {

        }
    }
}

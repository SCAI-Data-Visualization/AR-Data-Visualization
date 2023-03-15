using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

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
            prefab = SceneBuilderController.gameObject;
            GameObject SpawnPoint = GameObject.Find("SpawnPoint");
            GameObject Button = Instantiate(prefab);
            Transform ParentTransform = SpawnPoint.transform;
            Button.transform.SetParent(ParentTransform);
            var location = sceneElements.locations;
            Button.transform.localPosition = new Vector3(location[0][0] * 100, location[0][1] * 100, 0);


            JsonHelper.coordinateReader(sceneElements);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

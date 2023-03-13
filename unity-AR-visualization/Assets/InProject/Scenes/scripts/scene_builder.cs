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
        public JsonHelper sceneElements;
        public GameObject prefab; 

        // Start is called before the first frame update
        void Start()
        {
            sceneElements = SceneBuilderController.jsonHelper;
            prefab = SceneBuilderController.gameObject;
            GameObject SpawnPoint = GameObject.Find("SpawnPoint");
            Vector3 position = SpawnPoint.transform.position;
            Instantiate(prefab, position, Quaternion.identity);
        }

      /*  public void task_generate(JsonHelper sceneElements, GameObject prefab)
        {
            JsonHelper.coordinateReader(sceneElements);
            //make some objects
        }*/

        // Update is called once per frame
        void Update()
        {

        }
    }
}

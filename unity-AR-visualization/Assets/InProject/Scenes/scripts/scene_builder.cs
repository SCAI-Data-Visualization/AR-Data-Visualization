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
            prefab = SceneBuilderController.gameObject;
            GameObject SpawnPoint = GameObject.Find("SpawnPoint");
            GameObject Button = Instantiate(prefab);
            Transform ParentTransform = SpawnPoint.transform;
            Button.transform.SetParent(ParentTransform);
            var location = sceneElements.locations;
            Button.transform.localPosition = new Vector3(location[0][0] * 100, location[0][1] * 100, 5);
            
            JsonHelper.coordinateReader(sceneElements);

            //EventTrigger trigger = GetComponent<EventTrigger>();
            EventTrigger.Entry entry = new EventTrigger.Entry();
            entry.eventID = EventTriggerType.Select;
            entry.callback.AddListener((eventData) => { Debug.Log("Mkaljdflkjasdlfkj"); });
            //trigger.triggers.Add(entry);
            Button.GetComponent<EventTrigger>().triggers.Add(entry);
        }

        public void onClick()
        {
            Debug.Log("Made it with click");
            // Read in json file from JsonLoader.cs
            // Call load scene again 
        }

        //Option 1. add event listener to the prefab in the start function
        //          have the listener point to a new function in this script
        //          that handles the desired functions of pressing on click 
        //Option 2. write an on click function in this script and attach it 
        //          to the object that is made in unity (unsure if this will
        //          work because the prefab is not premade

        // Update is called once per frame
        void Update()
        {

        }
    }
}

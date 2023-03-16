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
            Button.transform.localPosition = new Vector3(location[0][0] * 100, location[0][1] * 100, 5);
            
            JsonHelper.coordinateReader(sceneElements);

            //EventTrigger trigger = GetComponent<EventTrigger>();
            EventTrigger.Entry entry = new EventTrigger.Entry();
            entry.eventID = EventTriggerType.PointerClick;
            entry.callback.AddListener((eventData) => { onClick(); });
            trigger.triggers.Add(entry);
            Button.GetComponent<EventTrigger>().triggers.Add(entry);
        }

        void onClick()
        {
            Console.WriteLine("Made it with click");
        }

        //Option 1. add event listener to the prefab in the start function
        //          have the listener point to a new function in this script
        //          that handles the desired functions of pressing on click 
        //Option 2. write an on click function in this script and attach it 
        //          to the object that is made in unity (unsure if this will
        //          work because the prefab is not premade

        // Update is called once per frame

        // Update is called once per frame
        void Update()
        {

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace jsonhelpernamespace
{
    public class StartButton : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        public void SceneBuilder()
        {
            JsonHelper sceneElements = GameObject.Find("Load_File").GetComponent<JsonLoader>().jsonHelper;

            UnityEngine.Debug.Log(sceneElements.size); //TODO: Delete log, only to show that flow from load -> start works
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

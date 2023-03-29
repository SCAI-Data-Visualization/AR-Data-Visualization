using jsonhelpernamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace jsonhelpernamespace
{
    public class continue_transition : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void transition()
        {
            Debug.Log("Made it with click");
            if(SceneBuilderController.level_num != -1)
            {
                JsonLoader load = new JsonLoader();
                SceneBuilderController.level_num = (SceneBuilderController.level_num + 1);
                load.readJSON();
                SceneManager.LoadScene("task_scene");
            }
            else if(SceneBuilderController.oneJSON == true)
            {
                SceneBuilderController.oneJSON = false;
                SceneManager.LoadScene("main_menu");
            }
            
        }
    }
}
using jsonhelpernamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace jsonhelpernamespace
{
    public class up_next_text : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Text textcomponent = GetComponent<Text>();
            if (SceneBuilderController.oneJSON == true)
            {
                textcomponent.text = "Up next: Back to Start.";
            }
            else if (SceneBuilderController.level_num == 2)
            {
                textcomponent.text = "Up next: Drag the puck into the goal.";
            }
            else if (SceneBuilderController.level_num == 5)
            {
                textcomponent.text = "Up next: Zoom the cube to each of the red goals.";
            }
            else if (SceneBuilderController.level_num == 8)
            {
                textcomponent.text = "Up next: Pan the screen until the goal is in target lines.";
            }
            else
            {
                textcomponent.text = "Up next: Same Task";
            }
        }
    }
}
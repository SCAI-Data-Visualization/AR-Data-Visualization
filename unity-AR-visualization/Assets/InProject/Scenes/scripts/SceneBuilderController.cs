using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace jsonhelpernamespace
{
    public class SceneBuilderController : MonoBehaviour
    {
        public static GameObject prefab_click;
        public static GameObject prefab_drag;
        public static GameObject prefab_drag_goal;
        public static JsonHelper jsonHelper;
        public static List<int> level_list;
        public static int level_num = -1;
        public static int currentIndex;
        public static bool oneJSON = false;
        public static string timerFinal;
    }
}

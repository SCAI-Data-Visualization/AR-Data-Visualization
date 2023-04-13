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
        public static GameObject prefab_zoom;
        public static GameObject prefab_zoom_goal;
        public static JsonHelper jsonHelper;
        public static List<int> level_list;
        public static int level_num = -1;
        public static int currentIndex;
        public static bool oneJSON = false;
        public static bool panTask = false;
        public static string timerFinal;
        public static int goals_done; //weird one, each goal will tick this value, used to ensure both goals are complete in pan/zoom
        public static float total_time;
    }
}

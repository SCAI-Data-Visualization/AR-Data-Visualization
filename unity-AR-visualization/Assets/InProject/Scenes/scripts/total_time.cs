using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace jsonhelpernamespace
{
    public class total_time : MonoBehaviour
    {
        public Text timeText;
        void Start()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(SceneBuilderController.total_time);
            string timeString = string.Format("{0:00}:{1:00}:{2:00}",
            Mathf.FloorToInt(SceneBuilderController.total_time / 60f), Mathf.FloorToInt(SceneBuilderController.total_time) % 60,
            Mathf.FloorToInt((SceneBuilderController.total_time * 100f) % 100f));
            SceneBuilderController.timerFinal = timeString;
            timeText.text = timeString;
        }
    }
}
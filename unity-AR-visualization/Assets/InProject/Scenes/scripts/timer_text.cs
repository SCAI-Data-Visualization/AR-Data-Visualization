using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace jsonhelpernamespace
{
    public class timer_text : MonoBehaviour
    {
        public timer timer;
        public Text timeText;
        void Update()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(timer.timeElapsed);
            string timeString = string.Format("{0:00}:{1:00}:{2:00}",
            Mathf.FloorToInt(timer.timeElapsed / 60f), Mathf.FloorToInt(timer.timeElapsed) % 60,
            Mathf.FloorToInt((timer.timeElapsed * 100f) % 100f));
            SceneBuilderController.timerFinal = timeString;
            timeText.text = timeString;
        }
    }
}
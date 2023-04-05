using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace jsonhelpernamespace
{
    public class timer_final : MonoBehaviour
    {
        public Text timeText;
        void Start()
        {
            timeText.text = SceneBuilderController.timerFinal;
        }
    }
}
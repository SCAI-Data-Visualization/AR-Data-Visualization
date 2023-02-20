using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
namespace Microsoft.MixedReality.Toolkit
{
    public class start : MonoBehaviour
    {
        public Interactable routingTarget;
        public enum PhysicalPressEventBehavior
        {
            EventOnClickCompletion = 0,
            EventOnPress,
            EventOnTouch
        }
        public PhysicalPressEventBehavior InteractableOnClick = PhysicalPressEventBehavior.EventOnClickCompletion;
        // Start is called before the first frame update

        // Update is called once per frame
        void Update()
        {

        }

        public void OnPress() {
            Debug.Log("Started Level");

        }

    }
}
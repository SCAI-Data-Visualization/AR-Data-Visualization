using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace jsonhelpernamespace
{
    public class status : MonoBehaviour
    {
        [SerializeField]
        public bool loaded_status;

        private Text textcomponent;
        public void changeStatus(bool newstatus)
        {
            loaded_status = newstatus;
            textcomponent = GetComponent<Text>();
            textcomponent.color = Color.green;
            textcomponent.text = "Loaded: True";
        }
    }


}
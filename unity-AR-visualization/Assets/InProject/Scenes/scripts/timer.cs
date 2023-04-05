using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace jsonhelpernamespace
{
    public class timer : MonoBehaviour
    {
        public float timeElapsed = 0f;
        // Start is called before the first frame update
        void Start()
        {
            timeElapsed = 0f;
        }


        void Update()
        {
            // Update the timeElapsed variable with the time that has passed since the game started
            timeElapsed += Time.deltaTime;
        }
    }
}
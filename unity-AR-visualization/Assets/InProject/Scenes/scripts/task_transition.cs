using jsonhelpernamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace jsonhelpernamespace
{
    public class task_transition : MonoBehaviour
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
            SceneManager.LoadScene("task_finished");
        }
    }
}
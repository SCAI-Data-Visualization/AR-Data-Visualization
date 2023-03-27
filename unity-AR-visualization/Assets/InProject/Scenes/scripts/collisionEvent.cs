using jsonhelpernamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace jsonhelpernamespace
{
    public class collisionEvent : MonoBehaviour
    {
        //Detect collisions between the GameObjects with Colliders attached
        void OnCollisionEnter(Collision collision)
        {
            Debug.Log("COLLISION DETECTED");
            Debug.Log(collision.gameObject.name);
            //Check for a match with the specified name on any GameObject that collides with your GameObject
            if (collision.gameObject.name == "Radial")
            {
                SceneManager.LoadScene("task_finished");
            }

        }
    }
}
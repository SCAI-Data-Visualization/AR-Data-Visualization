using jsonhelpernamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace jsonhelpernamespace
{
    public class zoomCollisionEvent : MonoBehaviour
    {
        public Material greenShader;
        public Material redShader;
        private bool isColliding = false;
        private bool is_done = false;
        private float collisionTime = 0f;
        private float collisionDuration = 1f;
        //Detect collisions between the GameObjects with Colliders attached
        void OnCollisionEnter(Collision collision)
        {
            Debug.Log("COLLISION DETECTED");
            //Check for a match with the specified name on any GameObject that collides with your GameObject
            if (collision.gameObject.name == "zoom_cube" || collision.gameObject.name == "zoom_cube(Clone)")
            {
                isColliding = true;
                Renderer renderer = GetComponent<Renderer>();
                renderer.material = greenShader;

            }

        }
        void OnCollisionExit(Collision collision)
        {
            isColliding = false;
            collisionTime = 0f;
            Renderer renderer = GetComponent<Renderer>();
            renderer.material = redShader;
        }
        void OnCollisionStay(Collision collision)
        {
            collisionTime += Time.deltaTime;
        }
        void done()
        {
            is_done = true;
        }
        void Start()
        {
            SceneBuilderController.goals_done = 0;
        }
        void Update()
        {
            if (collisionTime > collisionDuration && !is_done)
            {
                done();
                SceneBuilderController.goals_done += 1;
                Debug.Log("GOAL TICKED");
            }
            if (isColliding && (SceneBuilderController.goals_done == 4) && (collisionTime > collisionDuration))
            {
                SceneManager.LoadScene("task_finished");
            }
        }
    }
}
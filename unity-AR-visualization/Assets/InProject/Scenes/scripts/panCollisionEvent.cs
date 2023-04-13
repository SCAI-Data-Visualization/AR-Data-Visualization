using jsonhelpernamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace jsonhelpernamespace
{
    public class panCollisionEvent : MonoBehaviour
    {
        public Material greenShader;
        public Material redShader;
        private bool is_done = false;
        private bool isColliding = false;
        private float collisionTime = 0f;
        private float collisionDuration = 1f;
        //Detect collisions between the GameObjects with Colliders attached
        void OnCollisionEnter(Collision collision)
        {
            //Check for a match with the specified name on any GameObject that collides with your GameObject
            if (collision.gameObject.name == "Button")
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
            if (collisionTime > collisionDuration && !is_done && isColliding)
            {
                done();
                SceneBuilderController.goals_done += 1;
            }
            if (isColliding && (SceneBuilderController.goals_done == 2) && (collisionTime > collisionDuration))
            {
                if (SceneBuilderController.oneJSON)
                {
                    SceneManager.LoadScene("task_finished");
                }
                else
                {
                    SceneManager.LoadScene("trial_complete");
                }
            }
        }
    }
}
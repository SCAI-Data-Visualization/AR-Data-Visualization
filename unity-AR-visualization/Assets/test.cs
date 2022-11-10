using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        Debug.Log("Testing PR approval");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Will send out a message whenever the cube on scene is selected 
    public void OnSelect()
    {
        Debug.Log("The select action works!");
    }
}

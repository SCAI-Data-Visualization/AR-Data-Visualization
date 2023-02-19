using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("testingcube"); //Testing cube no longer in the scene
    }

    void DisappearFunction()
    {
        cube.GetComponent<Renderer>().enabled = false;
    }

    public void OnMouseDown()
    {
        DisappearFunction();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

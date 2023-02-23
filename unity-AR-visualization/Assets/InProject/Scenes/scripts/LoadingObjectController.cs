using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingObjectController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LoadingObject; 
    void Start()
    {
        LoadingObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

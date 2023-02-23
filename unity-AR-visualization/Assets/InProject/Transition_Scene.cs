using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Transition_Scene : MonoBehaviour
{
    public GameObject ToDisappear;
    public GameObject ToAppear;
    public void LoadScene()
    {
        ToDisappear.SetActive(false);
        ToAppear.SetActive(true);
    }
}

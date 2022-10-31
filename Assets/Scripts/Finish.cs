using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] AudioSource finishSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "MainPlayer")
        {
        SceneManager.LoadScene("End Scene");
        }
    }
}
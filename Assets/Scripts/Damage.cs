using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag ("Player"))
        {
            SceneManager.LoadScene(0);
            Debug.Log("You lose");
        }}
}

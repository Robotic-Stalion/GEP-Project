using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPoint : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Scoring.Score += 1;
        Destroy(gameObject);
    }
}
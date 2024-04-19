using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour



{
    
    public Transform target;
    public Transform MyTrasnform;
    
    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward*12*Time.deltaTime);
        
    }
}

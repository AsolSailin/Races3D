using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        // Move the vehicle forward
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward);
    }
}

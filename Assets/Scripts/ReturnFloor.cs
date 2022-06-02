using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFloor : MonoBehaviour
{
    [SerializeField] Transform ReturnPoint;

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = ReturnPoint.position;    
    }
}

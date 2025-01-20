using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalRight : MonoBehaviour
{
    [SerializeField] Transform transform;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.Translate(transform.position); 
        //moves player position to other side 
    }
}

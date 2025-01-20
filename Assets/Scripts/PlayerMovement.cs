using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    
    private float moveMultiplyer = 4f;

    [SerializeField] Rigidbody2D rb;
    Vector2 move;

   
    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }

    private void Update()
    {
        Run();
    }

    private void Run()
    {
        rb.velocity = move * 4;
    }
}

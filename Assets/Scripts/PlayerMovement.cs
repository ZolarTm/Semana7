using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Serial Permite editar privadas en el editor
    [SerializeField] private float speed;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        // Awake relaciona rigidbody auto
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();  
    }

    void Move()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        rb2d.velocity = new Vector2 (Horizontal, Vertical).normalized * speed;
    }
}

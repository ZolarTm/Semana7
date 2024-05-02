using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Vector2 Direccion;
    private Rigidbody2D rb2d;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    public void SetDirection(Vector2 direction)
    {
        this.Direccion = direction;
    }
    

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        rb2d.velocity = Direccion * speed;
    }
}

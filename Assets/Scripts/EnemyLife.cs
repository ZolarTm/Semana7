using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [SerializeField] private int Life;

    private void changelife(int value)
    {
        Life -= value;
        if (Life <= 0)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        changelife(1);

    }
}

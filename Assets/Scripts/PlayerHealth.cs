using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameManager manager;
    public int health = 3;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Damaged!!!");
            health -= 1;
            if (health <= 0)
            {
                Destroy(gameObject);
                manager.GameOver();
            }
        }
    }
}

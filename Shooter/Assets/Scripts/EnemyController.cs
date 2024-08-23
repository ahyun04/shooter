using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PlayerBullet(Clone)")
        {
            Object.Destroy(collision.gameObject);
            Object.Destroy(this.gameObject);
        }
    }
}

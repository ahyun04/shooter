using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{
    public float moveSpeed;

    void Start()
    {
       
    }

    void Update()
    {
        this.transform.Translate(Vector3.up * this.moveSpeed * Time.deltaTime);
        if (this.transform.position.y <= 7f)
        {
            Destroy(this.gameObject);
        }
        Debug.Log("Bullet Y Position: " + this.transform.position.y);
    }
}

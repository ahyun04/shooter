using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Animator animator;
    public GameObject playerBulletPrefab;
    //public Transform firePoint;

    void Start()
    {
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        Move();

        if(Input.GetKeyDown(KeyCode.A))
        {
            GameObject playerBulletGo = Object.Instantiate(this.playerBulletPrefab);
            Vector3 tagetPosition = this.transform.position;
            tagetPosition.y += 0.798f;
            playerBulletGo.transform.position = tagetPosition;
            //GameObject bullet = Instantiate(playerBulletPrefab, firePoint.position, firePoint.rotation);
        }
    }

    public void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        //방향 속도 시간
        Vector3 dir = new Vector3(h, v, 0);
        Vector3 movemaent = dir.normalized * this.moveSpeed * Time.deltaTime;
        this.transform.Translate(movemaent);

        if (h == 0)
        {
            //transform.localScale = new Vector3(h, v, 0);
            this.animator.SetInteger("State", 0);
        }
        else if (h == 1)
        {
            this.animator.SetInteger("State", 2);
        }
        else if (h == -1)
        {
            this.animator.SetInteger("State", 1);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posion : MonoBehaviour
{
    GameObject target;
    public float speed;
    Rigidbody2D posionRB;
    GameObject spider;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        spider = GameObject.FindGameObjectWithTag("Spider");
        posionRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        posionRB.velocity = new Vector2(moveDir.x, moveDir.y);
        Destroy(this.gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (target.transform.position.x > spider.transform.position.x)
        {
            transform.localScale = new Vector3(-0.5f, 0.5f, 1) ;

        }

    }
}
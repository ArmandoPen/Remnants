using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stinger : MonoBehaviour
{
    GameObject target;
    public float speed;
    Rigidbody2D bulletRB;
    GameObject bee;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        bee = GameObject.FindGameObjectWithTag("Bee");
        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
        Destroy(this.gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (target.transform.position.x > bee.transform.position.x)
        {
            transform.localScale = new Vector3(-2, 2, 1);

        }
       





    }


}

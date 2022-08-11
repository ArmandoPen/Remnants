using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderFollow : MonoBehaviour
{
    public float speed;
    public float lineOfSite;
    public float shootingRange;
    public float fireRate = 1f;
    private float nextFireTime;
    public GameObject Poison;
    public GameObject PosionParent;
    private Transform Player;
    internal Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        float distanceFromPlayer = Vector2.Distance(Player.position, transform.position);
        if (distanceFromPlayer < lineOfSite && distanceFromPlayer > shootingRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Player.position, speed * Time.deltaTime);
            animator.SetBool("Spidermove", false);
        }
        else if (distanceFromPlayer <= shootingRange && nextFireTime < Time.time)
        {
            Instantiate(Poison, PosionParent.transform.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;
            animator.SetBool("Spidermove", true);

        }
        if (Player.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
        else if (Player.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }


    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
        Gizmos.DrawWireSphere(transform.position, shootingRange);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Fire"))
        {
            Destroy(gameObject);
        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject fire;
    public BoxCollider2D flame;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))

        {
            fire.active = true;
            flame.enabled = true;
        }
        else
        {
            fire.active = false;
            flame.enabled = false;
        }
    }
}

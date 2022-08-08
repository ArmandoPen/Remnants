using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject fire;
    public Transform spawnPoint;
    public Transform Trash;

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
        }
        else
        {
            fire.active = false;
        }
    }
}

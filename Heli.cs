using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heli : MonoBehaviour
{
    public float speed = 10f;
    public float distanta = 50f;
    private bool sus = true;
    private float poz_init;

    // Start is called before the first frame update
    void Start()
    {
        poz_init = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(sus == true)
        {
            transform.Translate(new Vector3(0, 1 ,0) * Time.deltaTime * speed);
            if(transform.position.y > poz_init + distanta)
            {
                sus = false;
            }
        }
        else
        {
            transform.Translate(new Vector3(0, -1 ,0) * Time.deltaTime * speed);
            if(transform.position.y < poz_init - distanta)
            {
                sus = true;
            }
        }
    }
}

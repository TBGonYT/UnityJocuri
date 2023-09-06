using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elicePrincipala : MonoBehaviour
{

    public float speed_f = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, speed_f, 0) * Time.deltaTime);   
    }
}

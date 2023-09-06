using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliceSecundara : MonoBehaviour
{
    public float speed_b = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(speed_b, 0, 0) * Time.deltaTime);   
    }
}

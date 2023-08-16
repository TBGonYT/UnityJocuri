using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_plan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate (new Vector3 (2, 5, 6) *Time.deltaTime);
       transform.Rotate (new Vector3 (1000, 2000, 4543) *Time.deltaTime); 
    }
}

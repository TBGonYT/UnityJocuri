using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public int rotatie = 0;
    public int pasi = 0;

    private int test = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate (new Vector3 (0, 50, 0) *Time.deltaTime);
       transform.Translate (new Vector3 (2, 0, 0) *Time.deltaTime); 
    }
}

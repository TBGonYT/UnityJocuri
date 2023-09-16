using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miscare : MonoBehaviour
{

    public float viteza = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 miscare = new Vector3(horizontalInput, 0, verticalInput);

        transform.Translate(miscare * Time.deltaTime * viteza);


    }
}

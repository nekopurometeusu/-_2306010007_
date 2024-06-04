using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallContloler : MonoBehaviour
{
    public float speed = 5f;
    Ragidbody myragidbody;
    // Start is called before the first frame update
    void Start()
    {
        myragidbody = GetComponent<Ragidbody>();
        myragidbody.velocity = new Vector3(speed, speed, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

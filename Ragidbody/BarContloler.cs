using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarContloler : MonoBehaviour
{
    public float speed = 10f;
    Ragidbody myRagidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRagidbody = GetComponent<Ragidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        myRagidbody.Velocity = new Vector3(Input.GetAxis("Horizonal") * speed, 0f, 0f);
    }
}

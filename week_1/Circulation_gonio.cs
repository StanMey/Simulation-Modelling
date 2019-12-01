using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulation_gonio : MonoBehaviour
{
    private GameObject centerPlanet;

    private Rigidbody rb;

    float timeCounter = 0;

    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        centerPlanet = GameObject.FindWithTag("center");

        rb = GetComponent<Rigidbody>();

        difference = Vector3.Distance(centerPlanet.transform.position, rb.transform.position);
    }

    void FixedUpdate()
    {
        timeCounter += Time.deltaTime;

        float x = difference * Mathf.Cos(timeCounter);
        float y = 1;
        float z = difference * Mathf.Sin(timeCounter);

        transform.position = new Vector3 (x, y, z);
    }
}

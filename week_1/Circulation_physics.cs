using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulation_physics : MonoBehaviour
{

    private GameObject centerPlanet;
    public float mass;
    public Vector3 force;
    public Vector3 acceleration;
    public Vector3 velocity;
    public Vector3 startForce;


    // Start is called before the first frame update
    void Start()
    {
        centerPlanet = GameObject.FindWithTag("center");
        velocity = new Vector3(1, 0, 0);
    }

    void FixedUpdate()
    {
        Vector3 diff = centerPlanet.transform.position - transform.position;
        force = 7 * (diff * (1 / Mathf.Pow(diff.magnitude, 2)));
        acceleration = force / mass;
        velocity += acceleration;
        transform.position += velocity * Time.deltaTime;
    }
}

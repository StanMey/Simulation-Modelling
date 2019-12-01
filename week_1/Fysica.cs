using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fysica : MonoBehaviour
{
    public Vector3 force;
    public Vector3 acceleration;
    public Vector3 velocity;
    public int mass;

    // Start is called before the first frame update
    void Start()
    {
        force = new Vector3(0, -10, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        force = -100 * transform.position - 1 * velocity;
        acceleration = force / mass;
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
    }
}

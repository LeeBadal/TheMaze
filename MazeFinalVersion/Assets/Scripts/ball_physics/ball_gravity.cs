using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_gravity : MonoBehaviour
{

    public float thrust = 0.1f;
    public Rigidbody rb;
    public float bounce_force = 100.0f;
    public Rigidbody platform;
    public movePlaneRestrict platform_vars;
    public GameObject platformG;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        platformG = GameObject.Find("Cube.003");
        platform_vars = platformG.GetComponent<movePlaneRestrict>();


    }
    void Update()
    {

        Debug.Log(platform_vars.trackedx);
    }
    
}
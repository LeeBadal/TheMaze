using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlaneRestrict : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }



    Vector3 currentEulerAngles;
    [SerializeField] public int trackedz = 0;
    [SerializeField]  int maximumRotationz = 100;

    [SerializeField] public float trackedx = 0;
    [SerializeField]  int maximumRotationx = 100;

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey("right") && trackedz<maximumRotationz)
        {
            trackedz++;
            transform.Rotate(0.1f,0,0);
        }
        if (Input.GetKey("down") && trackedx<maximumRotationx)
        {
            trackedx++;
            transform.Rotate(0,0,-0.1f, Space.World);
        }
        if (Input.GetKey("left") && trackedz>-maximumRotationz)
        {
            trackedz--;
            transform.Rotate(-0.1f,0,0);
        }
        if (Input.GetKey("up") && trackedx>-maximumRotationx)
        {
            trackedx--;
            transform.Rotate(0,0,0.1f, Space.World);
        }

        //currentEulerAngles += new Vector3(basex, basey, z);
        //transform.GetChild (1).eulerAngles = currentEulerAngles;

    }
}

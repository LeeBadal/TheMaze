using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlaneRestrictRL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }



    Vector3 currentEulerAngles;
    [SerializeField] int trackedz = 0;
    [SerializeField]  int maximumRotationz = 100;



    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey("right") && trackedz<maximumRotationz)
        {
            trackedz++;
            transform.Rotate(0.1f,0,0);
        }

        if (Input.GetKey("left") && trackedz>-maximumRotationz)
        {
            trackedz--;
            transform.Rotate(-0.1f,0,0);
        }


        //currentEulerAngles += new Vector3(basex, basey, z);
        //transform.GetChild (1).eulerAngles = currentEulerAngles;

    }
}

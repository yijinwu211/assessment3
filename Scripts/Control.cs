using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    float fall = 0;
    public float fallSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KeyControl();
    }


    void KeyControl()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Rotate(0, 0, -90);

        }

        else if (Input.GetKeyDown(KeyCode.S) || Time.time - fall >= fallSpeed)
        {
            transform.position += new Vector3 (0,-1,0);


            fall = Time.time;
        }
        }


    }





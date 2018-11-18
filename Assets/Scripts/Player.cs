using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float radius = 3f;

    private float angle;
	
	void Start ()
    {
        angle = 270;	
	}
	
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            angle -= 2f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            angle += 2f;
        }
        //angle = Mathf.Clamp(angle, 180, 360);

        transform.position = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad) * radius, Mathf.Sin(angle * Mathf.Deg2Rad) * radius, transform.position.z);

        //transform.Translate(Vector3.forward * 5 * Time.deltaTime);
	}
}

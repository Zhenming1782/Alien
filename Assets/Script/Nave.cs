using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
	public GameObject proyectil;
	private float direccion;
	
	// Start is called before the first frame update
    void Start()
    {
        
    }

    public float getDireccion()
    {
	    return direccion;
    }
	
	void FixedUpdate()
	{
		if(direccion>0.0f)
			gameObject.transform.Translate(0,0.05f*direccion,0);
		else
		gameObject.transform.Translate(0,-0.05f,0);
	}

    // Update is called once per frame
    void Update()
    {
	    if (Input.GetKeyDown("space"))
	    {
		    Instantiate(proyectil, transform.position, Quaternion.Euler(0,0,90));
	    }
        direccion = Input.GetAxis("Vertical");

        if (Math.Abs(transform.position.y) > 5f)
        {
	        Destroy(gameObject);
        }
    }
}

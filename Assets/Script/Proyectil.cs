using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Proyectil : MonoBehaviour
{
    public Vector3 direccion;

    public Boolean esProyectil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Proyectil temp = other.GetComponent<Proyectil>();
        if (temp != null)
        {
            if (temp.esProyectil)
            {
                Destroy(gameObject);
                if (GetComponent<SpriteRenderer>().color == Color.blue)
                {
                    ScoreScript.scoreValue += 10;
                    Debug.Log("Si");
                }
                else
                {
                    ScoreScript.scoreValue += 1;
                    Debug.Log("No");
                }
            }
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(direccion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

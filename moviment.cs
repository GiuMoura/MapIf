using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviment : MonoBehaviour
{ public float vel=3;
  public float velgi = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            if (Input.GetKey("a"))
            {
                transform.Rotate(0, velgi * Time.deltaTime, 0);
            }
            if (Input.GetKey("d"))
            {
                transform.Rotate(0, -(velgi * Time.deltaTime), 0);
            }
            transform.Translate(0,0,vel * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, velgi * Time.deltaTime, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, -(velgi * Time.deltaTime), 0);
        }
    }
}

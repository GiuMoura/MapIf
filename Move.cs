using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float inputY;
    public float inputX;
    private Animator animator_;
    // Start is called before the first frame update
    void Start()
    {

        animator_=this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) {
            inputY = 0;
            inputX = 1; }
            else if (Input.GetKey("a"))
            {
                inputX = 2;
                inputY = 2;
            }
                else if (Input.GetKey("d"))
                   {
                     inputX = 2;
                     inputY = 1;
                    }
        else
        {
            inputY = 0;
            inputX = 0;
        }
                

        animator_.SetFloat("Y", inputY);
        animator_.SetFloat("X", inputX);
    }
}

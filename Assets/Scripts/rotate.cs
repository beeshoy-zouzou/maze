using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    
    Animator anim;
    bool move;

    // Start is called before the first frame update
    void Start()
    {
        move =false;
        anim = GetComponent<Animator>();
        anim.SetBool("isRotating" , false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)){
            
            anim.SetBool("isRotating",true);

        }
        if (Input.GetKeyDown(KeyCode.R) ){
            anim.SetBool("isRotating",false);
        }
        if (Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.B)){
            anim.SetBool("isRotating",false);
        }
        if (Input.GetKeyDown(KeyCode.B)){
            anim.SetBool("isRotating",false);
        }
    
    }
}

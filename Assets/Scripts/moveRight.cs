using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRight : MonoBehaviour

{
    Animator anim;
     bool move;

    // Start is called before the first frame update
    void Start()
    {
        move =false;
        anim = GetComponent<Animator>();
        anim.SetBool("isMovingRight" , false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            
            anim.SetBool("isMovingRight",true);
            

        }
        if(Input.GetKeyDown("space")){
            
            anim.SetBool("isMovingRight",false);

        }
        if(Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.B)){
            
            anim.SetBool("isMovingRight",false);
            

        }
        // if (Input.GetKeyDown(KeyCode.A)){
        //     anim.SetBool("isMovingRight",false);
        // }
    }
}

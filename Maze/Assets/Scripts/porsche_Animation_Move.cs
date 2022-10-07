using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porsche_Animation_Move : MonoBehaviour
{
     Animator anim;
     bool move;

    // Start is called before the first frame update
    void Start()
    {
        move =false;
        anim = GetComponent<Animator>();
        anim.SetBool("isMovingForward" , false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            
            anim.SetBool("isMovingForward",true);

        }
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.B)){
            anim.SetBool("isMovingForward",false);
        }
        if (Input.GetKeyDown(KeyCode.Z)){
            anim.SetBool("isMovingForward",false);
        }
        if (Input.GetKeyDown(KeyCode.B)){
            anim.SetBool("isMovingForward",false);
        }
    }
}

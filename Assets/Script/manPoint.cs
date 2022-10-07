using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manPoint : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
//bool transition;
   
    void Start()

    {
     
        animator = GetComponent<Animator>();
      
        animator.SetBool("isPointing",false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            Debug.Log(animator.GetBool("isPointing"));
            animator.SetBool("isPointing", true);
           // Debug.Log("WEEEEEEEEEEEEE");
             //Debug.Log(isWalking);
        }
    
           else
           { animator.SetBool("isPointing",false);
           }

         
         
        
    }
    
}

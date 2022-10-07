using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animControl : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;

   
    void Start()

    {
     
        animator =GetComponent<Animator>();
        Debug.Log(animator.GetBool("isTurningL"));
        animator.SetBool("isTurningL",false);
        animator.SetBool("isWalking",false);
        animator.SetBool("isTurningR",false);
        
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) {
            Debug.Log(animator.GetBool("isWalking"));
            animator.SetBool("isWalking", true);
            

           // Debug.Log("WEEEEEEEEEEEEE");
             //Debug.Log(isWalking);
        }
        else if(Input.GetKeyDown("d")){
            animator.SetBool("isTurningR", true);
        }
        else if(Input.GetKeyDown("a")){
            Debug.Log(animator.GetBool("isTurningL"));
            animator.SetBool("isTurningL", true);
        }
        else if(Input.GetKeyDown("s")){
            transform.Rotate(0, 180, 0);
        }

        
    
           else{
                animator.SetBool("isWalking",false);
                animator.SetBool("isTurningR", false);
                animator.SetBool("isTurningL", false);
      
         }
        
    }
    
}

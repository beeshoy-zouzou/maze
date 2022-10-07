using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class womanNodding : MonoBehaviour
{
    Animator animator;
//bool transition;
   
    void Start()

    {
     
        animator =GetComponent<Animator>();
        
        animator.SetBool("isNodding",false);
        


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {
            Debug.Log(animator.GetBool("isNodding"));
            animator.SetBool("isNodding", true);
           // Debug.Log("WEEEEEEEEEEEEE");
             //Debug.Log(isWalking);
        }
    
           else{ animator.SetBool("isNodding",false);
           }
           if (Input.GetKeyDown(KeyCode.E)){
               animator.SetBool("isNodding",false);
           }
         
        
    }
}

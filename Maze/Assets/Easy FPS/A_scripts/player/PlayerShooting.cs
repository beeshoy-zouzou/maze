using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    
    public LayerMask mask;

    Camera cam;

    void Start()
    {
        cam=Camera.main;
    }

    void Update()
    {
        // Vector3 mousePos = Input.mousePosition;

        // mousePos.z= 0f;
        // mousePos= cam.ScreenToWorldPoint(mousePos);
        // Debug.DrawRay(transform.position, mousePos - transform.position, Color.blue);
        bool mouseButtonDown = Input.GetMouseButtonDown(0);
        if(mouseButtonDown) {
            
            raycastOnMouseClick();  
        }
    }
    
    void shoot(RaycastHit hit){
        var projectile = Instantiate(projectilePrefab).GetComponent<Projectile>();
        var pointAboveFloor = hit.point + new Vector3(0, this.transform.position.y, 0);
        var direction = pointAboveFloor - transform.position;
        var shootRay = new Ray(this.transform.position, direction);
        
        Debug.DrawRay(shootRay.origin, shootRay.direction * 100.1f, Color.green, 2);
        Physics.IgnoreCollision(GetComponent<Collider>(), projectile.GetComponent<Collider>());
        projectile.FireProjectile(shootRay);
    }

    void raycastOnMouseClick()
    {
        RaycastHit hit;
        
        Ray rayToFloor = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        Debug.DrawRay(rayToFloor.origin, rayToFloor.direction * 100.1f, Color.red, 2);

        if (Physics.Raycast(rayToFloor, out hit, 1000f, mask, QueryTriggerInteraction.Collide))
        {
            shoot(hit);
        }
       
    }
}

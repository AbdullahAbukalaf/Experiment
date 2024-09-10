using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(212, 31, 31, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.1f;

    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    // This method is called when the collider is colliding with another object
   public void OnCollisionEnter2D(Collision2D other) {
   }

   // This method is called when the collider is triggering something
    public void OnTriggerEnter2D(Collider2D other) {
        // if you don't want to pick all the packages at the same time then you can add another condition 
        if(other.tag == "Package" && !hasPackage) {
            Debug.Log("You picked a package");
             // set the hasPackage to true
            hasPackage = true;
             // destroy the package when it crosses the line
            Destroy(other.gameObject, destroyDelay);
            // change the car color so that we know that the package is selected
            spriteRenderer.color = hasPackageColor;
        }
        if(other.tag == "Customer" && hasPackage){
            Debug.Log("Package has been delivered");
             // set the hasPackage to false
            hasPackage = false;
            // change the car color so that we know that the package is delivered
            spriteRenderer.color = noPackageColor;
        }
    }
}

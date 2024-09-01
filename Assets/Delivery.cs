using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // This method is called when the collider is colliding with another object
   public void OnCollisionEnter2D(Collision2D other) {
    Debug.Log("lol you just crashed the car");
   }

   // This method is called when the collider is triggering something
    public void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package"){
            Debug.Log("You picked a package");
            Destroy(other.gameObject); // destroy the package when it crosses the line
            RespawnPackage(); // respawn the package after it gets destroyed
        }else if(other.tag == "Customer"){
            Debug.Log("Package has been delivered");
            // Add code to handle customer collision
        }
    }

    // a method to respawn the package after it gets destroyed
    public Transform[] RespawnPoints;
    [SerializeField] GameObject Package;
    public void RespawnPackage(){
        // Check if respawnPoints array is empty
        if (RespawnPoints.Length == 0)
        {
            Debug.LogError("Respawn points not set! Please assign them in the Inspector.");
            return;
        }
        Debug.Log("GameObject");
        // choose a random location/position from the array
        int randomIndex = Random.Range(0, RespawnPoints.Length);
        Transform respawnPoint = RespawnPoints[randomIndex];
        
        // check if the package got destroyed
        if(Package != null){
            Instantiate(Package, respawnPoint.position, Quaternion.identity);
        }else{
            Debug.LogError("Package prefab not set! Please assign it in the Inspector.");
        }
    }
}

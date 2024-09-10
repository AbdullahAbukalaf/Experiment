using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // this things position (Camera position) should be the same as the car position
    [SerializeField] GameObject ThingToFollow;

    // Update is called once per frame
    // void Update()
    // {
    //     transform.position = ThingToFollow.transform.position + new Vector3(0, 0, -10);
    // }
    //LateUpdate is called after all Update methods have been called
    // and it's usually called for Following or positioning cameras 
    void LateUpdate()
    {
        transform.position = ThingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}

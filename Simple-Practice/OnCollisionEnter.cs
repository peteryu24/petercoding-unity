using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_componet : MonoBehaviour
{
    public float power = 10.0f; 
    public GameObject ball; // have to choose ball in the inspector
    Vector3 launch_direction = new Vector3(10, 500, 300);

    void OnCollisionEnter(Collision crash)
    {
        GetComponent<AudioSource>().Play();

        if (crash.gameObject.name == "Cube") // when cube contacts sphere(this file is applied to sphere)
        {
            ball.GetComponent<Rigidbody>().AddForce(launch_direction * power);

        }
    }
    
        

   
           

    


}





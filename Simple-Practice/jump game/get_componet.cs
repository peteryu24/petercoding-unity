using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_componet : MonoBehaviour
{
    public float power = 10.0f;
    public GameObject ball;
    Vector3 launch_direction = new Vector3(10, 500, 300);

    // Start is called before the first frame update
    void OnCollisionEnter(Collision crash)
    {
        GetComponent<AudioSource>().Play();

        if (crash.gameObject.name == "Cube")
        {
            ball.GetComponent<Rigidbody>().AddForce(launch_direction * power);

        }
    }
    
        

   
           

    


}





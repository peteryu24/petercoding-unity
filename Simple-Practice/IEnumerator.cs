using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject wall4, wall5, wall6;


    // Start is called before the first frame update
    IEnumerator Start() // thread 
    {
        while (true)
        {
            float interval = Random.Range(1.0f, 2.0f);
            int height = Random.Range(-3, 5);
            int speed = Random.Range(-6, -3);

            if (speed == -4)
            {
                GameObject go = GameObject.Instantiate(wall4, new Vector3(0, height, 0), transform.rotation);
                wall_ctrl ctrl = go.gameObject.GetComponent<wall_ctrl>();
            }
            if (speed == -5)
            {
                GameObject go = GameObject.Instantiate(wall5, new Vector3(0, height, 0), transform.rotation);
                wall_ctrl ctrl = go.gameObject.GetComponent<wall_ctrl>();
            }
            if (speed == -6)
            {
                GameObject go = GameObject.Instantiate(wall6, new Vector3(0, height, 0), transform.rotation);
                wall_ctrl ctrl = go.gameObject.GetComponent<wall_ctrl>();
            }
            
            yield return new WaitForSeconds(interval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

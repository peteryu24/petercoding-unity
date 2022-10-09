using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_ctrl : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed * Time.deltaTime, 0, 0);
        
    }
}

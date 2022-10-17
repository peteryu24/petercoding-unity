using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScene : MonoBehaviour
{

    int i = -1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");   //debug log
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.U))
        {                                    // whenever 'U' is pressed and unpressed prints mouse position
            Debug.Log(Input.mousePosition);  // ex) U(928.00, 995.00, 0.00)
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {                                   // whenever the spacebar is pressed
            Debug.Log("Space " + ++i);       // doesn't work if it's pressed & still
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Mouse " + --i);
        }
    }
}

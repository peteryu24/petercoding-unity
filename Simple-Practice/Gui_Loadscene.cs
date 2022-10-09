using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal_ctrl : MonoBehaviour
{
    private bool is_collided = false;
    private bool suc = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void OnCollisionStay(Collision coll)
    {
        this.is_collided = true;
        coll.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }

    void OnGUI()
    {
        if (is_collided)
        {
            suc = true;
            GUI.Label(new Rect(Screen.width / 2 - 30, 80, 100, 40), "press any key. "); // gui is appeared on the screen
        }
    
    }
    // Update is called once per frame
    void Update()
    {
        if(suc == true && Input.anyKeyDown)
        {
            SceneManager.LoadScene("SampleScene"); // restarting the game
        }
    }

}

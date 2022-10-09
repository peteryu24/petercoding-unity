using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class jump_pow : MonoBehaviour
{
    public int jump_power;
    float sec;
    
    // Start is called before the first frame update
    void Start()
    {
        jump_power = Random.Range(5, 9);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(0, jump_power, 0);
        }

        sec += Time.deltaTime;
    }
    void OnCollisionEnter(Collision coll)
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(81, Screen.height - 60, 128, 32),"시간 경과: " + sec );
        GUI.Label(new Rect(81, Screen.height - 40, 128, 32),"점프력: " + jump_power.ToString() );
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_goal : MonoBehaviour
{
    public GameObject prefab = null;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {
        GameObject game_object = GameObject.Instantiate(prefab) as GameObject;
        game_object.transform.position = new Vector3(Random.Range(7.0f, 10.0f), Random.Range(-3.0f, 2.0f),0); // random func
    }
}

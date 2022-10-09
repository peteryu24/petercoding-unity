using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class gameroot_script : MonoBehaviour
{
    public Texture2D icon = null;
    private int unito_count = 0;
    public GameObject prefab = null;
    private AudioSource audio_source;
    public AudioClip appear_sound; //inspector 에 할 게 있.
    // Start is called before the first frame update
    void Start()
    {
        audio_source = gameObject.AddComponent<AudioSource>();
        audio_source.clip = appear_sound;
        audio_source.loop = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject game_object = GameObject.Instantiate (this.prefab) as GameObject;
            game_object.transform.position = new Vector3 (Random.Range(-2.0f, 2.0f), 1.0f, Random.Range(-2.0f, 2.0f));
            audio_source.Play();
            unito_count++;
        }


        
    }
    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, Screen.height - 64, 64, 64), icon);
        GUI.Label(new Rect(81, Screen.height - 40, 128, 32), unito_count.ToString());
    }
}

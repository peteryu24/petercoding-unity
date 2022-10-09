using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_translate : MonoBehaviour
{
    float speed = 5.0f;
    public float power = 500.0f; 
    public GameObject ball; // 옵젝 컨트롤 가
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        float distance_per_frame = speed * Time.deltaTime;
        float vertical_input = Input.GetAxis("Vertical");
        float horizontal_input = Input.GetAxis("Horizontal");
        Vector3 launch_direction = new Vector3(0, 1, 1);

        transform.Translate(Vector3.forward * vertical_input * distance_per_frame); // this 생략
        transform.Translate(Vector3.right * horizontal_input * distance_per_frame);

        if (Input.GetButtonDown("Fire1")) // 마우스 좌클릭 누르자마자 실
            ball.GetComponent<Rigidbody>().AddForce(launch_direction * power);

    }
}

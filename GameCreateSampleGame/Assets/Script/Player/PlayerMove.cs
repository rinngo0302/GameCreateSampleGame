using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    const float RANGE_W = 7;
    const float RANGE_H = 5;

    [SerializeField] float _speedX;
    [SerializeField] float _speedY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;

        if (Input.GetKey(KeyCode.Space))
            Debug.Log("Space");

        if (Input.GetKey(KeyCode.A) && x >= -RANGE_W)
        {
            transform.Translate(new Vector3(-_speedX, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) && x <= RANGE_W)
        {
            transform.Translate(new Vector3(_speedX, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) && y <= RANGE_H)
        {
            transform.Translate(new Vector3(0, _speedY, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && y >= -RANGE_H)
        {
            transform.Translate(new Vector3(0, -_speedY, 0) * Time.deltaTime);
        }
    }
}

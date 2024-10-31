using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction = Vector3.zero;
    public float speed = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        direction = new Vector3(x, y, 0);
        transform.position += direction * Time.deltaTime * speed;
    }
}

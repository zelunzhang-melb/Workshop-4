using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        var movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.x += 1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x -= 1f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement.y += 1f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement.y -= 1f;
        }
        transform.localPosition += new Vector3(movement.x, 0f, movement.y) * speed * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAxisMove : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}
    public float moveSpeed;
    public float destination;
    float ZPosition;
    // Update is called once per frame
    void Update()
    {
        ZPosition += this.moveSpeed * Time.deltaTime;
        //var axis = new Vector3(0.0f, 0.0f, 1.0f);
        //transform.localPosition = Mathf.PingPong(Time.time, 10);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, Mathf.PingPong(ZPosition, this.destination));
    }
}

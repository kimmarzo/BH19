using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityAI : MonoBehaviour
{
    public Transform target;
    public Transform myTransform;
    public float runningSpeed = 5f;

    void Update()
    {
        //transform.LookAt(target);
        //transform.Translate(Vector3.forward * runningSpeed* Time.deltaTime);
        transform.position += Vector3.back * Time.deltaTime * runningSpeed;
    }
}

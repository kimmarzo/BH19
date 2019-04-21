using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallHealth : MonoBehaviour
{
    public float health = 100;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "TargetCubeW")
        {
            health -= 10;
            Destroy(other.gameObject);
        }
    }
}

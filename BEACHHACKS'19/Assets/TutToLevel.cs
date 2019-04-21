using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutToLevel : MonoBehaviour
{
    public GameObject tutCube1;
    public GameObject tutCube2;
    public GameObject tutCube3;
    public GameObject leftGate;
    public GameObject rightGate;
    bool openGates = false;
    public float gateSpeed = .5f;
    public float waitTimeForGate = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tutCube1.activeInHierarchy == false && tutCube2.activeInHierarchy == false && tutCube3.activeInHierarchy == false)
        {
            openGates = true;
            StartCoroutine(initializingGate());
        }
    }

    IEnumerator initializingGate()
    {
        yield return new WaitForSeconds(waitTimeForGate);
        leftGate.transform.position += Vector3.left * Time.deltaTime * gateSpeed;
        rightGate.transform.position += Vector3.right * Time.deltaTime * gateSpeed;

        Debug.Log("OPEN GATE PLTHHHHHHHHHHH");
    }
}

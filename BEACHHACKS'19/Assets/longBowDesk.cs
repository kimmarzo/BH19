using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class longBowDesk : MonoBehaviour
{
    public GameObject Weapon;
    public float Speed = 6;

    private void Update()
    {
       if (Weapon.GetComponent<Valve.VR.InteractionSystem.ItemPackageSpawner>().justPickedUpItem == true)
        {
            transform.position += Vector3.left * Time.deltaTime * Speed;
        }
    }
}

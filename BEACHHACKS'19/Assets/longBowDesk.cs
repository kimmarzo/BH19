using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class longBowDesk : MonoBehaviour
{
    public GameObject Weapon;
    public float Speed = 0.2f;
    public GameObject BowTableSystem;
    private void Update()
    {
       if (Weapon.GetComponent<Valve.VR.InteractionSystem.ItemPackageSpawner>().justPickedUpItem == true)
        {
       
            transform.position += Vector3.down * Time.deltaTime * Speed;
        
        }
    }
}

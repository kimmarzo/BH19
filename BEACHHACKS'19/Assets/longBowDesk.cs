using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class longBowDesk : MonoBehaviour
{
    public GameObject Weapon;
    public float SpeedTable = 0.2f;
    public float SpeedTutCubes = 0.7f;
    public GameObject BowTableSystem;
    public GameObject tutorialCubes;
    public float tutCubeHeight = 15f;
    public bool isHolding = false;
    public GameObject LongBowSystem;

    private void Update()
    {
       if (Weapon.GetComponent<Valve.VR.InteractionSystem.ItemPackageSpawner>().justPickedUpItem == true)
        {

            isHolding = true;
        }

        if (isHolding == true)
        {
  
            transform.position += Vector3.down* Time.deltaTime* SpeedTable;
            if (tutorialCubes.transform.position.y < (tutCubeHeight+1))
            {
                tutorialCubes.transform.position += Vector3.up * Time.deltaTime * SpeedTutCubes;
                BowTableSystem.transform.position += Vector3.down * Time.deltaTime * SpeedTable;
            }

        }
    


    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wallHealth : MonoBehaviour
{
    public GameObject Spawner;
    [Header("Health System")]
    public float maxHealth = 100;
    public float damageInc = 10;

    [Header("GameOver Paramenters")]
    public float timerGOScreen = 3.0f;
    public GameObject GOScreen;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            maxHealth -= damageInc;
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        if (maxHealth <= 0)
        {
            //StartCoroutine(gameOverScreen());
            GOScreen.SetActive(true);
        }
    }

    public IEnumerator gameOverScreen()
    {
        GOScreen.SetActive(true);
        Spawner.SetActive(false);
        yield return new WaitForSeconds(timerGOScreen);
        SceneManager.LoadScene("mainLevel_K");
    }
}

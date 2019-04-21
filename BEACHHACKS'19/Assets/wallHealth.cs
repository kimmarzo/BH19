using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wallHealth : MonoBehaviour
{
    [Header("Health System")]
    public float maxHealth = 100;
    public float damageInc = 10;

    [Header("GameOver Paramenters")]
    public float timerGOScreen = 3.0f;
    public GameObject GOScreen;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "TargetCubeW")
        {
            maxHealth -= damageInc;
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        if (maxHealth <= 0)
        {
            StartCoroutine(gameOverScreen());
       
        }
    }

    public IEnumerator gameOverScreen()
    {
        //GOScreen.SetActive(true);
        yield return new WaitForSeconds(timerGOScreen);
        SceneManager.LoadScene("mainLevel");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControler : MonoBehaviour
{
    private Enemy[] neprijatelji;
    private void OnEnable()
    {
        neprijatelji = FindObjectsOfType<Enemy>();
    }
    void Update()
    {
        foreach (Enemy enemy in neprijatelji)
        {
            if (enemy != null)
            {
                return;
            }
        }
        Debug.Log("You killed all enemies");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

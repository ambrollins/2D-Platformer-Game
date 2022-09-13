using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    private LevelManager levelManager;
    private void Awake()
    {
        levelManager = GetComponent<LevelManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<PlayerController>() != null)
        {
            SoundManager.Instance.PlaySoundEffects(Sounds.ButtonClick1);
            //LevelManager.Instance.SetCurrentLevelComplete();
            LoadLevel();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    void LoadLevel()
    {
        SceneManager.LoadScene(2);
    }
}

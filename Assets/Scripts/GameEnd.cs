using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{

    public void PlayButton()
    {
        SoundManager.Instance.PlaySoundEffects(Sounds.ButtonClick2);
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

}
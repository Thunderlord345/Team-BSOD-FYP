using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseScript : MonoBehaviour
{
    bool isPaused;
    public GameObject background;

    public string menu;
    public string levelSelect;

    public AudioSource audioSource;
    public AudioClip buttonSound;

    public AudioSource levelAudio;
    // Start is called before the first frame update
    void Start()
    {
        background.SetActive(false);
        isPaused = false;
    }

    public void Pause()
    {
        audioSource.PlayOneShot(buttonSound);
        Time.timeScale = 0f;
        background.SetActive(true);
        isPaused = true;
    }

    public void Resume()
    {
        audioSource.PlayOneShot(buttonSound);
        Time.timeScale = 1f;
        background.SetActive(false);
        isPaused = false;
    }

    public void BackToMenu()
    {
        Resume();
        SceneManager.LoadScene(menu);
        AudioManager.instance.Play("Insert clip name here");
    }

    public void LevelSelect()
    {
        Resume();
        SceneManager.LoadScene(levelSelect);
        AudioManager.instance.Play("Insert clip name here");
    }

    public void Restart()
    {
        audioSource.PlayOneShot(buttonSound);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}

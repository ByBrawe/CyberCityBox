using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{


    public GameObject first;
    public GameObject setting;
    public Scrollbar volumeScrollbar;


 

    private void OnDisable()
    {
        // Scrollbar'�n de�erini kaydeder
        PlayerPrefs.SetFloat("Volume", volumeScrollbar.value);

    }


    public void Start()
    {
        first.SetActive(true);
        setting.SetActive(false);

        // Scrollbar'�n ba�lang�� de�erini ayarlar
        float volume = PlayerPrefs.GetFloat("Volume", 0.75f);
      
     


    }

    public void StartGame()
    {
        // "Game" sahnesine ge�i� yapar
        SceneManager.LoadScene("level 1");
    }

    public void GoToSettings()
    {

        first.SetActive(false);
        setting.SetActive(true);

    }

    public void ExitGame()
    {
        // Oyunu kapat�r
        Application.Quit();
    }

    public void BackToMenu()
    {

        first.SetActive(true);
        setting.SetActive(false);
    }

    public void BackToMenuAfterFinishingGame()
    {

        SceneManager.LoadScene("startScreen");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject panel;
    private GameObject currentChest;
    public ParticleSystem destroyEffect;
    public GameObject panel2;
    public TMP_Text sayi;
    public GameObject start;
    public GameObject ui;
    public GameObject finish;
    public GameObject yetersiz;


    public void Start()
    {
        PlayerPrefs.SetInt("sayi", 0);

       
        start.SetActive(true);
        ui.SetActive(false);
        transform.GetComponent<PlayerMovement>().enabled = false;


    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "chest")
        {
            currentChest = collision.gameObject;
            Cursor.visible = true;

            if (PlayerPrefs.GetInt("sayi") >= 4)
            {
                panel2.SetActive(true);
            }
            else
            {
                panel.SetActive(true);
            }
            

           Debug.Log("Çarpýþma gerçekleþti");
           transform.GetComponent<PlayerMovement>().enabled = false;
        }
    }

    public void boxFunc()
    {
        panel.SetActive(false);

        if (currentChest != null)
        {
            
            Destroy(currentChest);
            PlayerPrefs.SetInt("sayi", PlayerPrefs.GetInt("sayi") + 1);
            Instantiate(destroyEffect, currentChest.transform.position, Quaternion.identity);
            sayi.text = PlayerPrefs.GetInt("sayi").ToString();
        }

        Cursor.visible = false;
        transform.GetComponent<PlayerMovement>().enabled = true;

    }


    public void boxFunc2()
    {
        panel2.SetActive(false);

        if (currentChest != null)
        {

            Destroy(currentChest);
            PlayerPrefs.SetInt("sayi", PlayerPrefs.GetInt("sayi") + 1);
            Instantiate(destroyEffect, currentChest.transform.position, Quaternion.identity);
            sayi.text = PlayerPrefs.GetInt("sayi").ToString();
        }

        Cursor.visible = false;
        transform.GetComponent<PlayerMovement>().enabled = true;

    }

    public void startFun()
    {
        start.SetActive(false);
        ui.SetActive(true);

        Cursor.visible = false;
        transform.GetComponent<PlayerMovement>().enabled = true;

    }


    public void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "finish")
        {

            Cursor.visible = true;
            transform.GetComponent<PlayerMovement>().enabled = false;


            if (PlayerPrefs.GetInt("sayi") == 5)
            {
                finish.SetActive(true);
                ui.SetActive(false);
                
            }
            else
            {
                 
                yetersiz.SetActive(true);
                ui.SetActive(false);
            }
        }
    }

    public void finishFunc()
    {
        finish.SetActive(false);
        SceneManager.LoadScene("finishScreen");

    }

    public void yetersizFunc()
    {
        yetersiz.SetActive(false);
        ui.SetActive(true);
       
        transform.GetComponent<PlayerMovement>().enabled = true;
        Cursor.visible = false;
    }


}

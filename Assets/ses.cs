using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ses : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        float volume = PlayerPrefs.GetFloat("Volume");
        
        GetComponent<AudioSource>().volume = volume/ 3;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

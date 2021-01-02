﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class sceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
        StartCoroutine(ExampleCoroutine());
    }
    private IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(56);
        SceneManager.LoadScene("Gameplay");
    }
            
    void update()
    {
        if (Input.GetKey("a"))
        {
            Debug.Log("Kaka");
            SceneManager.LoadScene("Gameplay");
        }
    }
}

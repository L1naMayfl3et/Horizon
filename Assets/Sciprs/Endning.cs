using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endning : MonoBehaviour
{ 
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public GameObject audioSource3;

    private void Start()
    {
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        if (a.activeInHierarchy) 
        {
            Debug.Log("wah1");
          audioSource2.Play();
        }

        if (b.activeInHierarchy)
        {
            Debug.Log("wah2");

            audioSource2.Play();
        }
        if (c.activeInHierarchy)
        {
            Debug.Log("wah3");

            audioSource2.Play();
        }
        
        if (d.activeInHierarchy)
        {
            Debug.Log("wah4");

            audioSource2.Play();
        }

        if (a.activeInHierarchy && b.activeInHierarchy && c.activeInHierarchy && d.activeInHierarchy)
        {
            StartCoroutine(endScene());

        }

    }

    IEnumerator endScene()
    {
         Debug.Log("water");
          audioSource3.SetActive(false);
        audioSource.Play();
        yield return new WaitForSeconds (3);
          SceneManager.LoadScene("Loading");
        
    }
}

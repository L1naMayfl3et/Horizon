using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public GameObject particle;

    public float timer;

    private void Awake()
    {

    }

    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

    }

    IEnumerator conffetiTimer()
    {
        particle.SetActive(true);
        yield return new WaitForSeconds(timer);
        particle.SetActive(false);
        StopCoroutine(conffetiTimer());
    }
}
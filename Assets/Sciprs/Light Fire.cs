using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFire : MonoBehaviour
{

    [SerializeField] GameObject lightFire;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fire")
        {
            Debug.Log("fire collider");
            lightFire.SetActive(true);
            StartCoroutine(fireOff());
        }
    }

    IEnumerator fireOff ()
    {
        Debug.Log("numerator fire");
        yield return new WaitForSeconds(50f);
        lightFire.SetActive(false);
        yield return null;
    }

}

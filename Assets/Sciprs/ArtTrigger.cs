using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtTrigger : MonoBehaviour
{
    GameObject pedestal;
    GameObject artifact;
    [SerializeField] GameObject rune;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "art")
        {
            rune.SetActive(true);
        }
    }

}

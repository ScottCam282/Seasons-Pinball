using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostPowerUp : MonoBehaviour
{
    Animator frostControls;
    public AudioSource burst;
    void Start()
    {
        frostControls = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ball")
        {
            frostControls.SetTrigger("Burst");
            burst.Play();
            StartCoroutine(Deactivate());
        }
    }
    private IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(1.0f);
        gameObject.SetActive(false);
    }
}

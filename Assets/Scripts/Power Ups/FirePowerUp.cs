using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePowerUp : MonoBehaviour
{
    Animator fireControls;
    public AudioSource burst;
    void Start()
    {
        fireControls = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ball")
        {
            fireControls.SetTrigger("Burst");
            StartCoroutine(Deactivate());
            burst.Play();            
        }
    }
    private IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(1.0f);
        gameObject.SetActive(false);
    }
}

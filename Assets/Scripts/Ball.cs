using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour

{
    public static Ball instance;

    private Rigidbody2D rBody;
    public float launchPower;

    Animator ballControls;
    public static bool isFertilityBoost = false;
    public static bool isFireBoost = false;
    public static bool isNatureBoost = false;
    public static bool isFrostBoost = false;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        ballControls = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Launch();
        }
    }

    public void Launch()
    {
        var direction = new Vector2(0f, 1f);
        rBody.AddForce(direction * launchPower, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "FertilityPower")
        {
            FertilityBoost();
        }
        if (col.tag == "FirePower")
        {
            FireBoost();
        }
        if (col.tag == "NaturePower")
        {
            NatureBoost();
        }
        if (col.tag == "FrostPower")
        {
            FrostBoost();
        }
    }

    public void FertilityBoost()
    {
        StartCoroutine(FertBoost());
    }
    public IEnumerator FertBoost()
    {
        isFertilityBoost = true;
        ballControls.SetTrigger("Pink");
        yield return new WaitForSeconds(9f);
        ballControls.SetTrigger("UnPink");
        yield return new WaitForSeconds(20f);
        isFertilityBoost = false;
    }

    public void FireBoost()
    {
        StartCoroutine(FieryBoost());
    }
    public IEnumerator FieryBoost()
    {
        isFireBoost = true;
        ballControls.SetTrigger("Red");
        yield return new WaitForSeconds(9f);
        ballControls.SetTrigger("UnRed");
        yield return new WaitForSeconds(20f);
        isFireBoost = false;
    }

    public void NatureBoost()
    {
        StartCoroutine(NaturalBoost());
    }
    public IEnumerator NaturalBoost()
    {
        isNatureBoost = true;
        ballControls.SetTrigger("Green");
        yield return new WaitForSeconds(9f);
        ballControls.SetTrigger("UnGreen");
        yield return new WaitForSeconds(20f);
        isNatureBoost = false;
    }
    public void FrostBoost()
    {
        StartCoroutine(FrostyBoost());
    }
    public IEnumerator FrostyBoost()
    {
        isFrostBoost = true;
        ballControls.SetTrigger("Blue");
        yield return new WaitForSeconds(9f);
        ballControls.SetTrigger("UnBlue");
        yield return new WaitForSeconds(20f);
        isFrostBoost = false;
    }

}

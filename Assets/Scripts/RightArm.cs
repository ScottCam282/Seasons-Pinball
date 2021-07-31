using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RightArm : MonoBehaviour
{
    public float idleAngle;
    public float activeAngle;
    public Collider2D mat;

    public static RightArm instance = null;

    void Start()
    {
        transform.rotation = Quaternion.EulerAngles(0, 0, idleAngle);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            RFlip();
        }
        else if (Input.GetKeyUp(KeyCode.Keypad8))
        {
            RUFlip();
        }        
    }

    public void RFlip()
    {
        StartCoroutine(RightFlip());
    }

    public IEnumerator RightFlip()
    {
        transform.DORotate(new Vector3(0f, 0f, activeAngle), 0.1f);
        yield return new WaitForSeconds(0.1f);
        


    }
    public void RUFlip()
    {
        StartCoroutine(RightUnFlip());
    }

    public IEnumerator RightUnFlip()
    {
        transform.DORotate(new Vector3(0f, 0f, idleAngle), 0.1f);
        yield return new WaitForSeconds(0.1f);
    }
}

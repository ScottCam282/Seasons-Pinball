using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LeftArm : MonoBehaviour
{
    public float idleAngle;
    public float activeAngle;

    void Start()
    {
        transform.rotation = Quaternion.EulerAngles(0, 0, idleAngle);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            LFlip();
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            LUFlip();
        }
    }

    public void LFlip()
    {
        StartCoroutine(LeftFlip());
    }

    private IEnumerator LeftFlip()
    {
        transform.DORotate(new Vector3(0f, 0f, activeAngle), 0.1f);
        yield return new WaitForSeconds(0.1f);
    }

    public void LUFlip()
    {
        StartCoroutine(LeftUnFlip());
    }

    public IEnumerator LeftUnFlip()
    {
        transform.DORotate(new Vector3(0f, 0f, idleAngle), 0.1f);
        yield return new WaitForSeconds(0.1f);
    }
}

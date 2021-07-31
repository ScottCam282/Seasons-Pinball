using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlipperArm : MonoBehaviour
{
    public float idleAngle;
    public float activeAngle;
    public KeyCode keyCode;
    public float force;


    private float time;
    private float direction;
    private bool isFlipping;

    void Start()
    {
        time = 0f;
        direction = 1f;
        transform.rotation = Quaternion.EulerAngles(0, 0, idleAngle);
    }

    void Update()
    {
        if(Input.GetKeyDown(keyCode))
        {
            isFlipping = true;
            direction = 1f;
        }
    }

    private void FixedUpdate()
    {
        if (isFlipping)
        {
            Flip();
        }
    }

    public void Flip()
    {
        time = Mathf.Clamp(time + Time.fixedDeltaTime * direction * force, 0f, 1f);
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0f, 0f, idleAngle), Quaternion.Euler(0f, 0f, activeAngle), time);

        if (time >= 1.0f) {
            direction = -1f;
        }
        else if (time <= 0f) {
            direction = 1f;
            isFlipping = false;
        }

        //StartCoroutine(CFlip());
    }

    private IEnumerator CFlip()
    {
        transform.DORotate(new Vector3(0f, 0f, activeAngle), 0.1f);
        yield return new WaitForSeconds(0.1f);
        transform.DORotate(new Vector3(0f, 0f, idleAngle), 0.1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummerDayTime : MonoBehaviour
{
    Animator dayControls;
    // Start is called before the first frame update
    void Start()
    {
        dayControls = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.summerDay == true)
        {
            dayControls.SetTrigger("Day In");
        }
        if (GameManager.summerDay == false)
        {
            dayControls.SetTrigger("Day Out");
        }
    }
}

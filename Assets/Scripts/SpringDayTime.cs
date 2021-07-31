using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringDayTime : MonoBehaviour
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
        if (GameManager.springDay == true)
        {
            dayControls.SetTrigger("Day In");
        }
        if (GameManager.springDay== false)
        {
            dayControls.SetTrigger("Day Out");
        }
    }
}

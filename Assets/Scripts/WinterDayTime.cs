using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinterDayTime : MonoBehaviour
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
        /*if (GameManager.winterDay == true)
        {
            dayControls.SetTrigger("Day In");
        }
        if (GameManager.winterDay == false)
        {
            dayControls.SetTrigger("Day Out");
        }*/
    }
}

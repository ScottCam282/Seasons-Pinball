using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummerNightTime : MonoBehaviour
{
    Animator nightControls;
    // Start is called before the first frame update
    void Start()
    {
        nightControls = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.summerNight == true)
        {
            nightControls.SetTrigger("Night In");
        }
        if (GameManager.summerNight == false)
        {
            nightControls.SetTrigger("Night Out");
        }
    }
}

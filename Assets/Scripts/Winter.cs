using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winter : MonoBehaviour
{
    Animator seasonControls;
    // Start is called before the first frame update
    void Start()
    {
        seasonControls = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (GameManager.winterTime == true)
        {
            seasonControls.SetTrigger("Winter In");
        }
        if (GameManager.winterTime == false)
        {
            seasonControls.SetTrigger("Winter Out");
        }*/
    }
}

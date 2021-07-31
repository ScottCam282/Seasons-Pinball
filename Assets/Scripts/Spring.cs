using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    Animator seasonControls;
    // Start is called before the first frame update
    void Start()
    {
        seasonControls = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()

    {/*
        if (GameManager.springTime == true)
        {
            seasonControls.SetTrigger("Spring In");
        }
        if (GameManager.springTime == false)
        {
            seasonControls.SetTrigger("Spring Out");
        }*/
    }
}

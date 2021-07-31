using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autumn : MonoBehaviour
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
        /*if (GameManager.autumnTime == true)
        {
            seasonControls.SetTrigger("Autumn In");
        }
        if (GameManager.autumnTime == false)
        {
            seasonControls.SetTrigger("Autumn Out");
        }*/
    }
}

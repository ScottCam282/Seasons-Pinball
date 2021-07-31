using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summer : MonoBehaviour
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
        /*if (GameManager.summerTime == true)
        {
            seasonControls.SetTrigger("Summer In");
        }
        if (GameManager.summerTime == false)
        {
            seasonControls.SetTrigger("Summer Out");
        }*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    Animator launcher;
    // Start is called before the first frame update
    void Start()
    {
        launcher = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Return))
        {
            Launch();           
        }
        
    }

    public void Launch()
    {
        launcher.SetTrigger("Up");
    }



}

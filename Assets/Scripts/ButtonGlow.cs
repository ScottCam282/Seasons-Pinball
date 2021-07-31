using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGlow : MonoBehaviour
{
    Animator glowControls;
    // Start is called before the first frame update
    void Start()
    {
        glowControls = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Glow()
    {
        glowControls.SetTrigger("Glow");
    }
    public void UnGlow()
    {
        glowControls.SetTrigger("UnGlow");
    }
}

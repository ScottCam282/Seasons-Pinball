using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FertilityNode : MonoBehaviour
{
    Animator fertilityNodeControls;
    public AudioSource nodeSound;
    // Start is called before the first frame update
    void Start()
    {
        fertilityNodeControls = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {

            GameManager.fertility += 1;
            fertilityNodeControls.SetTrigger("Light");
            nodeSound.Play();
            if (Ball.isFireBoost == true)
            {
                GameManager.fire += 1;
            }
            if (Ball.isFertilityBoost == true)
            {
                GameManager.fertility += 1;
            }
            if (Ball.isNatureBoost == true)
            {
                GameManager.nature += 1;
            }
            if (Ball.isFrostBoost == true)
            {
                GameManager.frost += 1;
            }
        }
    }
}

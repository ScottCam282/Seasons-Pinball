using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NatureNode : MonoBehaviour
{
    Animator natureNodeControls;
    public AudioSource nodeSound;
    // Start is called before the first frame update
    void Start()
    {
        natureNodeControls = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {

            GameManager.nature += 1;
            natureNodeControls.SetTrigger("Light");
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

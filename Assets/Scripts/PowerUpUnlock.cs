using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpUnlock : MonoBehaviour
{
    public GameObject Lock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ball")
        {
            StartCoroutine(DisableLock());
        }

    }
    /*public void UnLock()
    {
        StartCoroutine(DisableLock());
    }*/

    private IEnumerator DisableLock()
    {
        Lock.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        Lock.SetActive(true);
    }
}

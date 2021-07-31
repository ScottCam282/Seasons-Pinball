using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelLock : MonoBehaviour
{
    public GameObject Lock;
    public GameObject launchButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UnLock()
    {
        StartCoroutine(DisableLock());
    }

    private IEnumerator DisableLock()
    {
        Lock.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        Lock.SetActive(true);
        launchButton.SetActive(false);
    }
}

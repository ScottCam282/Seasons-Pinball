using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentEffects : MonoBehaviour
{
    public GameObject effects1 = null;
    public GameObject effects2 = null;
    public GameObject effects3 = null;
    public GameObject effects4 = null;

    void Start()
    {
        effects1.SetActive(false);
        effects2.SetActive(false);
        effects3.SetActive(false);
        effects4.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        effects1.SetActive(true);
        yield return new WaitForSeconds(1);
        effects2.SetActive(true);
        yield return new WaitForSeconds(2);
        effects3.SetActive(true);
        yield return new WaitForSeconds(3);
        effects4.SetActive(true);
    }

    private void Despawn()
    {
        effects1.SetActive(false);
        effects2.SetActive(false);
        effects3.SetActive(false);
        effects4.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static int frost = 0;
    public static int nature = 0;
    public static int fertility = 0;
    public static int fire = 0;
    public static int life = 0;
    public static int lifeGoal = 0;
    public static int year = 0;

    public static bool springDay = false;
    public static bool springNight = false;
    public static bool summerDay = false;
    public static bool summerNight = false;
    public static bool autumnDay = false;
    public static bool autumnNight = false;
    public static bool winterDay = false;
    public static bool winterNight = false;

    public static bool springTime = false;
    public static bool summerTime = false;
    public static bool autumnTime = false;
    public static bool winterTime = false;

    public GameObject Spring;
    Animator springControls;



    void Start()
    {
        MakeSingleton();
        frost = 5;
        nature = 3;
        fertility = 3;
        fire = 5;
        life = 3;
        lifeGoal = 950;
        year = 1;

        springControls = Spring.GetComponent<Animator>();
        //var ballRenderer = ball.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
       //StartCoroutine(Cycle());
    }

    private void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

 /*   public IEnumerator Cycle()
    {
        springTime = true;
        springControls.SetTrigger("Spring In");
        yield return new WaitForSeconds(5f);
        springControls.SetTrigger("Spring Out");
        springTime = false;

        summerTime = true;
        yield return new WaitForSeconds(5f);
        summerTime = false;
        autumnTime = true;
        yield return new WaitForSeconds(5f);
        autumnTime = false;
        winterTime = true;
        yield return new WaitForSeconds(5f);
        winterTime = true;
    }*/
}

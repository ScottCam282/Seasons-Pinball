using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Elements : MonoBehaviour
{
    //public Text counterText;
    public TextMeshProUGUI FrostScore, NatureScore, LifeScore, LifeGoal, FertilityScore, FlameScore, YearNumber;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FrostScore.SetText(GameManager.frost.ToString());
        NatureScore.SetText(GameManager.nature.ToString());
        LifeScore.SetText(GameManager.life.ToString());
        LifeGoal.SetText(GameManager.lifeGoal.ToString());
        FertilityScore.SetText(GameManager.fertility.ToString());
        FlameScore.SetText(GameManager.fire.ToString());
        YearNumber.SetText(GameManager.year.ToString());
    }
}

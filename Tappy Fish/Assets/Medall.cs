using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Medall : MonoBehaviour
{
    public Sprite metalMedal, BrozeMedal, silverMeadal, goldMeal;
    Image img;

    void Start()
    {
        img = GetComponent<Image>();

        int gameScore = GameManager.gameScore;

        if (gameScore > 0 && gameScore <= 1)
        {
            img.sprite = metalMedal;
        }
        else if (gameScore > 1 && gameScore <= 2)
        {
            img.sprite = BrozeMedal;
        }
        else if (gameScore > 2 && gameScore <= 3)
        {
            img.sprite = silverMeadal;
        }
        else if (gameScore > 3)
        {
            img.sprite = goldMeal;
        }
    }

   
    void Update()
    {
        
    }
}

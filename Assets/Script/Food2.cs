using TMPro;
using UnityEngine;


public class Food2 : MonoBehaviour
{
    public int Calories;
    public TextMeshPro CaloriesText;

    void Start()
    {
        Calories = Random.Range(4, 6);
     
        CaloriesText.SetText(Calories.ToString());
    }

   
}

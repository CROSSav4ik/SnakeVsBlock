using TMPro;
using UnityEngine;


public class Food1 : MonoBehaviour
{
    public int Calories;
    public TextMeshPro CaloriesText;

    void Start()
    {
        Calories = Random.Range(2, 3);
     
        CaloriesText.SetText(Calories.ToString());
    }

   
}

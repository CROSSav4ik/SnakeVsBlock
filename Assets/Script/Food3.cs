using TMPro;
using UnityEngine;


public class Food3 : MonoBehaviour
{
    public int Calories;
    public TextMeshPro CaloriesText;

    void Start()
    {
        Calories = Random.Range(7, 9);
     
        CaloriesText.SetText(Calories.ToString());
    }

   
}

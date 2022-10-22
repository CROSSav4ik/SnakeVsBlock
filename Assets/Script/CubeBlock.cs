
using TMPro;
using UnityEngine;

public class CubeBlock : MonoBehaviour
{
    public TextMeshPro DurabilityText;
    public int Durability;
    Color Color = Color.yellow;
    

    void Start()
    {
        Durability = Random.Range(1, 10);
        DurabilityText.SetText(Durability.ToString());
        Color = Color.Lerp(Color.yellow, Color.red, (float)Durability / 10f);
        this.GetComponent<Renderer>().material.color = Color;
    }

    
}

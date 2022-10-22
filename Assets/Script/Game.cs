
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public SnakeMove Controls;
    public Text LvlNumb;
    public int Lvl = 1;
    public GameObject WinScreen;
    public GameObject LossScreen;
    public GameObject Salute1;
    public GameObject Salute2;
    private AudioSource _road;
        

    public enum State
    {
        Playing,
        Won,
        Loss,
    }

    public State CurrenteState { get; private set; }

    private void Awake()
    {
        _road = GetComponent<AudioSource>();
        LvlNumb.text = "Level " + Lvl.ToString();

    }
    public void Victory()
    {
        if (CurrenteState != State.Playing)
        {
            return;
        }
        CurrenteState = State.Won;
        Controls.enabled = false;
        Salute1.SetActive(true);
        Salute2.SetActive(true);
        Debug.Log("Winner!");
        WinScreen.SetActive(true);
    }

    public void Death()
    {
        if (CurrenteState != State.Playing)
        {
            return;
        } 
        CurrenteState = State.Loss;
        Controls.enabled = false;
        Debug.Log("Game Over!");
        LossScreen.SetActive(true);
        _road.Stop();
        
    }
    





}

using UnityEngine.UI;
using UnityEngine;

public class SnakeEating : MonoBehaviour
{

    public int Value;
    public int Length;
    private SnakeTail snakeTail;
    public int Life = 1;
    public Text LifeTab;
    public Game Game;
    public AudioClip AudioClip;
    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    void Start()
    {
        
        snakeTail = GetComponent<SnakeTail>();
        
        LifeTab.text = Life.ToString();
        Life += Value;
        
        for (int i = 0; i < Value; i++)
        {
            Length++;
            snakeTail.AddBone();
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food1")
        {
            Value = collision.gameObject.GetComponent<Food1>().Calories;

            _audio.Play();
            Destroy(collision.gameObject);
            Life += Value;
            LifeTab.text = Life.ToString();
            for (int i = 0; i < Value; i++)
            {
                Length++;
                snakeTail.AddBone();
            }

        }

        if (collision.gameObject.tag == "Food2")
        {
            Value = collision.gameObject.GetComponent<Food2>().Calories;
            Life += Value;
            LifeTab.text = Life.ToString();
            _audio.Play();
            Destroy(collision.gameObject);

            for (int i = 0; i < Value; i++)
            {
                Length++;
                snakeTail.AddBone();
            }

        }
        if (collision.gameObject.tag == "Food3")
        {
            Value = collision.gameObject.GetComponent<Food3>().Calories;
            Life += Value;
            LifeTab.text = Life.ToString();
            _audio.Play();
            Destroy(collision.gameObject);

            for (int i = 0; i < Value; i++)
            {
                Length++;
                snakeTail.AddBone();
            }

        }
        if (collision.gameObject.tag == "Block")
        {
            _audio.PlayOneShot(AudioClip);
            Value = collision.gameObject.GetComponent<CubeBlock>().Durability;
            if (Value >= Life)
            {
                Game.Death();
               
            }
            else
            {
                Life -= Value;
                LifeTab.text = Life.ToString();
                Destroy(collision.gameObject);

                for (int i = 0; i < Value; i++)
                {
                    Length--;
                    snakeTail.DeleteBone();
                }
            }

        }
    }
}  


       
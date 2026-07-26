using TMPro;
using UnityEngine;

public class NewGM : MonoBehaviour
{
     public static NewGM instance{get; private set;}

    public float GameDuration = 300;

    public bool playing = true;

    public int score = 0;
    
    public GameObject prefab;

    public float timer = 10;

   
    public TextMeshPro countimg;

    public TextMeshPro scoreimg;

   

    void Awake()
    {
        //singletion pattern so that it can be accessed by any other script
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateTicket();
    }

    // Update is called once per frame
    void Update()
    {
      GameDuration -= Time.deltaTime;
      if(GameDuration <= 0)
        {
            Endgame();
        }
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            if(playing)
            {
                Ramen.instance.SubmitBowl();
            }
        timer = 10;
        }
        countimg.text = timer.ToString("F0");

        scoreimg.text = score.ToString();
    }

     public void Endgame()
    {
        playing = false;
    }
    public void AddScore(int amount, GameObject target)
    {
        score += amount * 100;
        if(target != null)
        {
        Destroy(target);
        }
        
        GenerateTicket();
        timer = 10;
    }

    public void GenerateTicket()
    {
        Instantiate(prefab, new Vector2(3,3),Quaternion.identity);
    }
    
    public void CountDown()
    {
        
    }
}

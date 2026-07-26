using UnityEngine;
using UnityEngine.InputSystem.Utilities;

//purpose of a gamemanager is to control of the gamestate of the current gameplay
public class GameManager : MonoBehaviour
{
    public static GameManager instance{get; private set;}

    public float timer = 1;

    public float GameDuration = 300;

    public bool playing = true;

    public int score = 4000;
    
    //public GameObject prefab;

   

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
       // Instantiate(prefab, new Vector2(0,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        //this will determince what actions will occur while gameplay is currently active.
         while(playing)
         {
            // timer -= Time.deltaTime;
             if(timer <= 0)
             {
                 //call update timer function on the ui script and call update timer on ramen script.
             }
             GameDuration -= Time.deltaTime;
             if(GameDuration <= 0)
             {
               //  Endgame();
             }
        }
    }

    
    public void AddScore(int amount)
    {
        score += amount;
    }
}

using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class Ticket : MonoBehaviour
{
   public List<string> ingredients = new List<string>();

   public GameObject ticket_list;

   public string[] toppings = {"Chives","Egg","Meat","Oil","Salt","Seaweed"};

   public TextScript tex;

   public bool set = false;

   

   
    void Start()
    {
        tex = ticket_list.GetComponent<TextScript>();
        ingredients.Add("Broth");
        ingredients.Add("Ramen");
        GenerateTicket();
      
    }

    // Update is called once per frame
    void Update()
    {
        if(this)
        {
            PrintTicket();
            if(!set)
            {
                NewTicket();
                set = true;
            }
        }
    }

    public void NewTicket()
    {
        Ramen.instance.NewBowl(gameObject);
    }

    public void PrintTicket()
    {
       
        if(tex != null)
        {
            if(this){
            tex.SetText(this);
            }
        }
    }

    public void GenerateTicket()
    {
        ingredients.Add(toppings[Random.Range(0,6)]);
        ingredients.Add(toppings[Random.Range(0,6)]);
        
     
    }

    public void CompareTicket(List<string> ramen)
    {
        int score = 0;
        foreach(string i in ramen)
        {
            foreach(string j in ingredients)
            {
                if (i == j)
                {
                    score++;
                }
            }
        }
        NewGM.instance.AddScore(score,gameObject);
    }
}

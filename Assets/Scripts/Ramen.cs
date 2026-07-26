using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Ramen : MonoBehaviour
{

    public static Ramen instance {get; private set;}
    public List<string> ingredients = new List<string>();

    public Ticket customer;

    public AudioSource effects;

    public AudioClip sfx;

    public AudioClip plate;

    public TextMeshPro bowl_ingredients;


    void Awake()
    {
         if(instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    // Update is called once per frame
  

    public void AddIngredient(string ingredient)
    {
        if(ingredients.Count < 4)
        {
        effects.PlayOneShot(sfx);
        ingredients.Add(ingredient);
        bowl_ingredients.text += ingredient;
        bowl_ingredients.text += "\n";
        }
       
            
    }

    public void ClearRamenBowl()
    {
        ingredients.Clear();
    }

    public void NewBowl(GameObject ticket)
    {
        customer = ticket.GetComponent<Ticket>();
        ClearRamenBowl();
    }

    public void SubmitBowl()
    {
        effects.PlayOneShot(plate);
        customer.CompareTicket(ingredients);
        bowl_ingredients.text = " ";
    }
}

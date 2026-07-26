using System.Collections.Generic;
using UnityEngine;

public class Ramen : MonoBehaviour
{

    public static Ramen instance {get; private set;}
    public List<string> ingredients = new List<string>();

    public Ticket customer;


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
        ingredients.Add(ingredient);
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
        customer.CompareTicket(ingredients);
    }
}

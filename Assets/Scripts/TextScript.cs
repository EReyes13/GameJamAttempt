using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextScript : MonoBehaviour
{
    public TextMeshPro ticket;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ticket = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetText(Ticket order)
    {
        ticket.text = order.ingredients[0] + "\n" + order.ingredients[1] + "\n" + order.ingredients[2] + "\n" + order.ingredients[3];
    }
}

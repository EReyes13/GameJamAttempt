using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndScript : MonoBehaviour
{
    public TextMeshProUGUI final_score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        final_score.text = NewGM.instance.score.ToString();
    }

    public void BakcToLobby()
    {
        SceneManager.LoadScene(0);
    } 
}

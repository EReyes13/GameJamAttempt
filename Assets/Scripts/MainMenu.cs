using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public Button tutorial;

    public AudioClip theme;
    public AudioSource player;

    public AudioSource effects;

    public AudioClip sfx;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        
    }
    void Start()
    {
        player.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTutorial()
    {
        effects.PlayOneShot(sfx);
        tutorial.gameObject.SetActive(true);
    }

    public void StartGame()
    {
        effects.PlayOneShot(sfx);
        SceneManager.LoadScene(1);
    }
}

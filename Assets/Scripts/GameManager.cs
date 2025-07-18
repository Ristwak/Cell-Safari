using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject homePanel;
    public GameObject aboutPanel;
    public GameObject loadingPanel;

    // Start is called before the first frame update
    void Start()
    {
        homePanel.SetActive(true);
        aboutPanel.SetActive(false);
        loadingPanel.SetActive(false);
    }

    public void StartButton()
    {
        loadingPanel.SetActive(true);
        SceneManager.LoadScene("AnimalCell");
        homePanel.SetActive(false);
        aboutPanel.SetActive(false);
        // Load the first scene or start the game logic
        Debug.Log("Game Started");
    }

    public void AboutButton()
    {
        homePanel.SetActive(false);
        aboutPanel.SetActive(true);
    }

    public void BackButton()
    {
        aboutPanel.SetActive(false);
        homePanel.SetActive(true);
    }

    public void QuitButton()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }
}

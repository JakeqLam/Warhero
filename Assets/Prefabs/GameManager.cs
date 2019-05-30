using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScreenshotHandler.TakeScreenshot_static(1900, 1600);
        }
    }

    public GameObject completeLeveUI;

    public void CompleteLevel() 
    {
        completeLeveUI.SetActive(true);
    }

    public void LoadNextLevel() 
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeunMainControls : MonoBehaviour
{
    [SerializeField] AudioSource buttonPress;
    [SerializeField] GameObject fadeout;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void StartGame()
    {
        buttonPress.Play();
        fadeout.SetActive(true);
        LevelMaintain.levelNumber = 4;
        StartCoroutine(PlayTheGame());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator PlayTheGame()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(4);
    }
}

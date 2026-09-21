using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
    [SerializeField] GameObject playerControl;
    [SerializeField] AudioSource levelJingle;
    [SerializeField] GameObject levelBGM;
    [SerializeField] GameObject fadeOut;

    void OnTriggerEnter(Collider other)
    {
        playerControl.GetComponent<PlayerControls>().enabled = false;
        playerControl.GetComponent<Animator>().Play("Idle");
        levelBGM.SetActive(false);
        levelJingle.Play();
        fadeOut.SetActive(true);
        StartCoroutine(ToNextLevel());
    }

    IEnumerator ToNextLevel()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(5);
    }    
}

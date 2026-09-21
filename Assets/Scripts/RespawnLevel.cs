using UnityEngine;
using UnityEngine.SceneManagement;

public class RespaenLevel : MonoBehaviour
{
    void Start()
    {
        ScoreControl.totalScore = 0;
        SceneManager.LoadScene(LevelMaintain.levelNumber);
    }
}

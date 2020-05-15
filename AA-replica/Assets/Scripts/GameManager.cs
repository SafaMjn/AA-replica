using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private bool isGameOver = false;
    public Animator animator;

    public  int pinCount ;
    public TMP_Text score_txt;


    void Start()
    {
        pinCount = 0;
        score_txt.text = pinCount.ToString();
    }

    public void EndGame()
    {
        Rotation_ctr.Instance.enabled = false;
        PinSpawner_ctr.Instance.enabled = false;

        isGameOver = true;

        animator.SetTrigger("EndGame");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SetScore()
    {
        score_txt.text = pinCount.ToString();
    }
}

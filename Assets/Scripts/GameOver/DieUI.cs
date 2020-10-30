using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class DieUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _startBtn, _exitBtn;

    void Start()
    {
        FadeOut();
    }
    void FadeOut()
    {
        _startBtn.GetComponent<CanvasGroup>().DOFade(1, 3f);
        _exitBtn.GetComponent<CanvasGroup>().DOFade(1, 3f);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}

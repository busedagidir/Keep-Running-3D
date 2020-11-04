using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _startBtn, _exitBtn, _settingBtn;
    void Start()
    {
        FadeOut();
    }

    void FadeOut()
    {
        _startBtn.GetComponent<CanvasGroup>().DOFade(1, 3f);
        _exitBtn.GetComponent<CanvasGroup>().DOFade(1, 3f);
        _settingBtn.GetComponent<CanvasGroup>().DOFade(1, 3f);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

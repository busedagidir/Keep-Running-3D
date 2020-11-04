using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Text scoreText;

    private float startZ;
    private float score;

    private void Start()
    {
        startZ = Mathf.Abs(player.position.z);
    }
    void Update()
    {
        score = startZ + player.position.z;
        scoreText.text = score.ToString("0");
        PlayerPrefs.SetFloat("Score", score);
    }
}

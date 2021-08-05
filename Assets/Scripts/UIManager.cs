using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;




public class UIManager : MonoBehaviour
{
    #region Singleton class: ObstacleControl
    public static UIManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #endregion

    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameObject losePanel;
    [SerializeField] GameObject winPanel;
    [HideInInspector] public int score;

    private void Start()
    {
        //Paneller deaktif edilir.
        losePanel.SetActive(false);
        winPanel.SetActive(false);
    }
    private void Update()
    {
        //Score ekrana yazd�r�l�r.
        scoreText.text = score.ToString();
    }

    public void ShowLosePanel()
    {
        //LosePanel g�sterilir.
        losePanel.SetActive (true);
        winPanel.SetActive(false);

    }
    public void ShowWinPanel()
    {
        //WinPanel g�sterilir.
        losePanel.SetActive(false);
        winPanel.SetActive(true);
    }

    public void Restart()
    {
        //oyun yeniden ba�lar.
        SceneManager.LoadScene(0);
    }
}

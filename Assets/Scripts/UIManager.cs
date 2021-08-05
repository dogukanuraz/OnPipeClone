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
        //Score ekrana yazdýrýlýr.
        scoreText.text = score.ToString();
    }

    public void ShowLosePanel()
    {
        //LosePanel gösterilir.
        losePanel.SetActive (true);
        winPanel.SetActive(false);

    }
    public void ShowWinPanel()
    {
        //WinPanel gösterilir.
        losePanel.SetActive(false);
        winPanel.SetActive(true);
    }

    public void Restart()
    {
        //oyun yeniden baþlar.
        SceneManager.LoadScene(0);
    }
}

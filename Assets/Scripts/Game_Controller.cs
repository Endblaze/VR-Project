using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Controller : MonoBehaviour
{

    //SINGLETON ---------------------------------------------------------------

    private static Game_Controller _instance;

    public static Game_Controller Instance
    {

        get
        {
            return _instance;
        }

    }

    private void Awake()
    {
        
        if(_instance == null)
        {
            _instance = this;
        }

    }

    //GAME CONTROLLER ---------------------------------------------------------

    public TextMesh txtScore;

    public TextMesh txtGameOver;

    [HideInInspector] public float speed = 1;
    [HideInInspector] public bool end = false;

    private float score;

    private void Update()
    {

        if (end)
        {

            if (speed != 0)
            {

                speed = 0;
                txtGameOver.gameObject.SetActive(true);

            }

            Color col = txtGameOver.color;

            col.a += Time.deltaTime / 1;

            txtGameOver.color = col;

            if(col.a > 1)
            {

                Invoke("EndGame", 1);
                
            }

        }

    }

    public void AddScore(float points)
    {

        score += points;
        speed += .1f;

        txtScore.text = "Score: " + score;

    }

    private void EndGame()
    {

        PlayerPrefs.SetFloat("LastScore", score);

        if (PlayerPrefs.GetFloat("Record") < score)
        {
            PlayerPrefs.SetFloat("Record", score);
        }

        SceneManager.LoadScene("Menu");

    }

}
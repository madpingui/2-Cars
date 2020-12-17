using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{   
    public GameObject[] BlueGO;
    public GameObject[] OrangeGO;

    public float startWait;
    public float spawnWait;

    GameObject Blue, Orange;

    float[] XPosition = new float[2] { 1.12f, 4f };

    int Score;
    public Text ScoreText;

    public GameObject GameOverCanvas;

    void Start()
    {
        Time.timeScale = 1;
        GameOverCanvas.SetActive(false);
    }

    IEnumerator SpawnObjects()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < 50; i++)
            {
                //choosing Xpos
                float OrangeXpos = XPosition[Random.Range(0, XPosition.Length)];
                //setting position
                Vector3 OrangePos = new Vector3(OrangeXpos, 15, 0);
                //choosing between square or circle
                Orange = OrangeGO[Random.Range(0, OrangeGO.Length)] as GameObject;
                //Instantiate now
                Instantiate(Orange, OrangePos, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);

                //choosing Xpos
                float BlueXpos = -XPosition[Random.Range(0, XPosition.Length)];
                //setting position
                Vector3 BluePos = new Vector3(BlueXpos, 15, 0);
                //choosing between square or circle
                Blue = BlueGO[Random.Range(0, BlueGO.Length)] as GameObject;
                //Instantiate now
                Instantiate(Blue, BluePos, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);
            }
           
        }
    }
    public void StartGame()
    {   
        StartCoroutine(SpawnObjects());
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverCanvas.SetActive(true);
    }
    public void AddScore()
    {
        Score += 1;
        ScoreText.text = Score.ToString();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

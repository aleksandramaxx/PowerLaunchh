//using System.Numerics;
//using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    private Vector3 inicijalnaPozicija;
    private bool birdLaunch;
    private float timerBird;
    public GameObject m;
    public GameObject r;
    public GameObject p;
    public GameObject againn;
    public GameObject gameO;
    public GameObject quitt;
    [SerializeField] private float launchMoc = 500;
    private void Awake()
    {
        Time.timeScale = 1;
        inicijalnaPozicija = transform.position;
    }
    private void Update()
    {
        GetComponent<LineRenderer>().SetPosition(0, transform.position);
        GetComponent<LineRenderer>().SetPosition(1, inicijalnaPozicija);

        if (birdLaunch && GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1)
        {
            timerBird += Time.deltaTime;
            m.SetActive(true);
            r.SetActive(true);
            p.SetActive(true);
        }
        if (transform.position.y > 10 || transform.position.y < -7 || transform.position.x > 18 || transform.position.x < -16 || timerBird > 3)
        {
            //string trenutnoIme = SceneManager.GetActiveScene().name;
            //SceneManager.LoadScene(trenutnoIme);
            Time.timeScale = 0;
            againn.SetActive(true);
            gameO.SetActive(true);
            quitt.SetActive(true);
        }
    }
    public void Again()
    {
        string trenutnoIme = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(trenutnoIme);
    }
    public void Quitt()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void MenuuButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void ReplayButton()
    {
        Time.timeScale = 1f;
        string tIme = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(tIme);
    }
    bool issPaused = false;
    public void PauseGame()
    {
        if (issPaused)
        {
            Time.timeScale = 1;
            issPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            issPaused = true;
        }
    }
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().material.color = Color.red;
        GetComponent<LineRenderer>().enabled = true;

    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().material.color = Color.white;

        Vector2 directionToInicijalnaPozicija = inicijalnaPozicija - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directionToInicijalnaPozicija*launchMoc);
        GetComponent<Rigidbody2D>().gravityScale = 1;
        birdLaunch = true;

        GetComponent<LineRenderer>().enabled = false;
    }
    private void OnMouseDrag()
    {
        Vector3 novaPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(novaPosition.x, novaPosition.y);
    }
}

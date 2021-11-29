using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> characters;

    // Start is called before the first frame update
    void Start()
    {
        Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        Time.timeScale = 1;
    }

    public void Stop()
    {
        Time.timeScale = 0;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

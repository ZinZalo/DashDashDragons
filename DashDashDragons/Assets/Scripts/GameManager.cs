using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> characters;
    //currentArrow stores the currently selected arrow as a variable.
    //0: Nothing
    //1: Up
    //2: Down
    //3: Left
    //4: Right
    public int currentArrow;

    // Start is called before the first frame update
    void Start()
    {
        Stop();
        currentArrow = 0;

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

    public void LevelExit()
    {
        //TODO: once all levels are finished this code will move to the next level
        Stop();
    }

    //Load test level
    public void LoadTest()
    {
        SceneManager.LoadScene("Test Level", LoadSceneMode.Single);
    }

    public void SelectUpArrow()
    {
        currentArrow = 1;
    }

    public void SelectDownArrow()
    {
        currentArrow = 2;
    }

    public void SelectLeftArrow()
    {
        currentArrow = 3;
    }

    public void SelectRightArrow()
    {
        currentArrow = 4;
    }
}

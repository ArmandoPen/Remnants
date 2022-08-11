using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOver : MonoBehaviour
{
    public string levelname;
    public GameObject enemies;
    public TextMeshProUGUI monsters;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemies.transform.childCount <= 0)
        {
            SceneManager.LoadScene(levelname);
        }
        monsters.text = "enemies left:" + enemies.transform.childCount;
    }
}

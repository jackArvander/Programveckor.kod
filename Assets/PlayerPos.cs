using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{

    private GameMaster gm;

    private void Start()
    {

        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPointPos;
        
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        
    }

}

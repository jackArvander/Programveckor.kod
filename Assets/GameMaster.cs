using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// skapad av vincent fajersson
public class GameMaster : MonoBehaviour
{

    private static GameMaster instance;
    public Vector2 lastCheckPointPos; // sparar spelarens position f�r checkpoint

    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

}

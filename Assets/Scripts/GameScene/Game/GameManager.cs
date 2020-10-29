using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    public GameState GameState { get; set; }
    public bool CanSwipe { get; set; }

    protected GameManager()
    {
        GameState = GameState.Start;
        CanSwipe = false;
    }

    public void Die()
    {
        this.GameState = GameState.Dead;
        Debug.Log("died");
    }

    
}

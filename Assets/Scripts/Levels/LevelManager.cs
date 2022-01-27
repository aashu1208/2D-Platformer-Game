using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager instance;
    public static LevelManager Instance { get { return instance; } }


    public void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
           
        }

    }

    public LevelStatus GetLevelStatus(string level)
    {
        LevelStatus levelstatus = (LevelStatus) PlayerPrefs.GetInt(level, 0);
        return levelstatus;

    }

    public void SetLevelStatus(string level, LevelStatus levelstatus)
    {

        PlayerPrefs.SetInt(level, (int)levelstatus);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

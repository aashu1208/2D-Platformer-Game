using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Button button;
    public string levelName;

    public GameObject levelScene;
    public GameObject playScene;
    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }


    public void OnClick()
    {
        LevelStatus levelstatus = LevelManager.Instance.GetLevelStatus(levelName);
        switch (levelstatus)
        {

            case LevelStatus.Locked:
                Debug.Log("Can't play this level till you unlocked the level");
                break;

            case LevelStatus.Unlocked:
                SceneManager.LoadScene(levelName);
                Debug.Log("Now, You can play ");
                break;

            case LevelStatus.Completed:
                SceneManager.LoadScene(levelName);
                break;
            //default:
                //break;
        }

        
        
    }

    
    public void ActiveLevelScene()
    {

        levelScene.SetActive(true);
        playScene.SetActive(false);
    }

}

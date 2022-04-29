using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyController : MonoBehaviour
{
    public SoundManager SoundManager;
    public GameObject LevelSelection;


    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayGame()
    {
        //SoundManager.Instance.Play(SoundManager.Instance.Sounds.ButtonClick);
        SoundManager.Instance.Play(Sounds.ButtonClick);
        LevelSelection.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

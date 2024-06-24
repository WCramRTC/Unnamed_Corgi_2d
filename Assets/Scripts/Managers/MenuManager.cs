using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public enum Scenes {MainMenu, Prototype}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Main_StartGame() {
        SceneManager.LoadScene((int)Scenes.Prototype);
    }


}

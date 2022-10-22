using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManeger : MonoBehaviour
{
    public void NextLevel(int _sceneNamber)
    {
        SceneManager.LoadScene(_sceneNamber);
    }
    
}

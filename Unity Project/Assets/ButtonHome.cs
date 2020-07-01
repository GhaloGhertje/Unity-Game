using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonHome : MonoBehaviour
{
    public void SceneLoader(int SceneIndex) 
    {
        SceneManager.LoadScene(SceneIndex);
    }
}

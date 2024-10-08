using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicscript : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public GameObject gameoverscreen;

    [ContextMenu ("increase score")]
    public void addscore() 
    { 
    score=score+1;
     scoretext.text = score.ToString();
    
    }
    public void restartgame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
    }
    public void gameover() { 
    gameoverscreen.SetActive(true);
    }




















}
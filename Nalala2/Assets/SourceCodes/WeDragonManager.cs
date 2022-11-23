using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WeDragonManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp;
    GameObject go;
    void Start()
    {
        hp = 2; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "attack") // Attack of boss dragon
        {
            this.hp--;
            go = GameObject.Find("weDragon");
            Gameover1 go1 = go.GetComponent<Gameover1>();
            Destroy(other.gameObject);
            go1.pro_time += 3;
        }
        if (hp <= 0)
        {
            //Destroy(gameObject);
            Debug.Log("Game Over");

            SceneManager.LoadScene("GameOverScene");
//#if UNITY_EDITOR
//            UnityEditor.EditorApplication.isPlaying = false;
//#else
//                    Application.Quit(); 
//#endif
        }
    }
}

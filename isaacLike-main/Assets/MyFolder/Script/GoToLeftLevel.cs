using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLeftLevel : MonoBehaviour
{
    public Player player;

    /*void OnTriggerEnter2D(Collider2D t2)
    {
        player = new Player();
        Debug.Log("Go To Left Level");
        player._move_LEFT();

        //230929
        simdata.EntryPoint = 3;
        Debug.Log(simdata.EntryPoint);

        //230929
        SceneManager.LoadScene("test");
    }
    */

    /*private void OnTriggerEnter2D(Collider2D t2)
    {
        if (t2.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // 衝突相手が指定したLayerに属している場合の処理
            player = new Player();
            Debug.Log("Go To Left Level");
            player._move_LEFT();

            //230929
            simdata.EntryPoint = 3;
            Debug.Log(simdata.EntryPoint);

            //231115
            MMGameEvent.Trigger("Save");

            //230929
            SceneManager.LoadScene("test");
        }
    }*/

    public void isGoToLeftLevelPressed()
    {
        Calc.GoToSomethingBottonPressed("Left");

        /*
        // 衝突相手が指定したLayerに属している場合の処理
        player = new Player();
        Debug.Log("Go To Left Level");
        player._move_LEFT();

        //230929
        simdata.EntryPoint = 3;
        Debug.Log(simdata.EntryPoint);

        //231115
        MMGameEvent.Trigger("Save");

        //230929
        SceneManager.LoadScene("test");
        */
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

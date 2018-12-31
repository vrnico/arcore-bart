using System.Collections;
using System.Collections.Generic;
using Unity Engine;
using GoogleARCore;
//don't forget this Google AR assembly

public class SceneController : MonoBehaviour {

  public ScoreboardController scoreboard;
  //reference scoreboard game object

  public SnakeController snakeController;
  //reference SnakeController game object

  public Camera firstPersonCamera;
  //reference game camera

  //Use this for initialization
  void Start () {
    QuitOnConnectionErrors ();
    //will quit if there is a problem connecting to ARCore or Android Device.
  }

  //Update is called once per frame
  void Update () {
        //the Session class manages AR system state and handles the session lifecycle. It is the main entry point to the ARCoreAPI.
        if (Session.Status != SessionStatus.Tracking)
        //the session status must be Tracking in order to access the frame.
        {
          int lostTrackingSleepTimeout = 15;
          Screen.sleepTimeout = lostTrackingSleepTimeout;
          //Screen dims after 15 second
        }

        ProcessTouches();
        //run process touches method in update in order 
  }

}

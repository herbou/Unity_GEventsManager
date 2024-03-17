using UnityEngine;
using UnityEngine.SceneManagement;

public class Emitter : MonoBehaviour {

    private void Update() {
        if (Input.GetKeyUp(KeyCode.A)) {
            // Emit (Invoke) event without passing any data:
            GEventsManager.Invoke(GEvents.KeyAPressed);
        }


        if (Input.GetKeyUp(KeyCode.Z)) {
            // Emit (Invoke) event and pass some data to listeners:
            GData data = new(
                Time.realtimeSinceStartup,          // 0  : first data
                SceneManager.GetActiveScene().name  // 1  : second data
                //...
                //...
            );
            GEventsManager.Invoke(GEvents.KeyZPressed, data);
        }
    }


}

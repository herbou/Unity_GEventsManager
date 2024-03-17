using UnityEngine;

public class Reciever : MonoBehaviour {

    private void OnEnable() {
        // Add listeners to the events :
        GEventsManager.AddListener(GEvents.KeyAPressed, On_A_Pressed_Handler);
        GEventsManager.AddListener(GEvents.KeyZPressed, On_Z_Pressed_Handler);
    }

    private void On_A_Pressed_Handler(GData data) {
        Debug.Log("Key A pressed");
    }

    private void On_Z_Pressed_Handler(GData data) {
        // Get passed data :
        var time = data.Get<float>(0);
        var sceneName = data.Get<string>(1);

        Debug.Log($"Key A pressed and data => time={time} and scene={sceneName}");
    }


    private void OnDisable() {
        // Always remove listeners when no longer needed, to prevent memory leaks and weired behaviors :
        GEventsManager.RemoveListener(GEvents.KeyAPressed, On_A_Pressed_Handler);
        GEventsManager.RemoveListener(GEvents.KeyZPressed, On_Z_Pressed_Handler);
    }

}

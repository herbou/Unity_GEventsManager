# Unity Event Manager :

Add an Event System to your game in Unity to reduce dependencies and improve maintainability.

Watch the video tutorial here 👉 : https://youtu.be/LyIu06jl7To

<br />
<br />

# Documentation :

## 🟦 1. Add the ```Game_Events_Manager.unitypackage``` package to your game.

<br />
<br />

## 🟦 2. Define your events :
Go to the `Assets/Scripts/Game Events Manager/` and open the `GEvents.cs` script:
```c#
public enum GEvents {
    //Define the names of your events here ..

    Player_Health_Damaged,
    Player_Killed,
    // ...
    // ...
}
```
This enumeration (enum) defines a list of the different events that can occur in our game.

Here we have defined two events : `Player_Health_Damaged` and `Player_Killed`.


<br />
<br />

## 🟦 3. Listen to the events :
```c#
GEventsManager.AddListener(GEvents.Player_Killed, On_Player_Killed_Handler);
```
The code registers an event listener for the `Player_Killed` event, specifying a callback function to be invoked whenever the event is triggered:
```c#
private void On_Player_Killed_Handler(GData data) {
    // do something...
}
```

<br />
<br />

## 🟦 4. Trigger the events :
```c#
GEventsManager.Invoke(GEvents.Player_Killed);
```
When the Invoke method is called, the event manager finds all the scripts registered for that event and executes their callback functions.

<br />
<br />

## 🟦 5. Send and recieve data :
The example we saw above is to trigger event without passing any data to listeners.
### ◪ Trigger an event and attach some data with it :
```c#
GEventsManager.Invoke(GEvents.Player_Health_Damaged, new GData(health, 100));
```
This code triggers the `Player_Health_Damaged` event, passing two pieces of information using a `GData` object : 


  `0`. the player's current health after damage
  
  `1`. the initial health value (100).

<br />

### ◪ Get the data in the callback :
```c#
GEventsManager.AddListener(GEvents.Player_Health_Damaged, On_Player_Health_Damaged_Handler);
```
```c#
private void On_Player_Health_Damaged_Handler(GData data) {
    // Get passed data :
    float current_health = data.Get<float>(0);
    float initial_health = data.Get<float>(1);

    // Or use var keyword :
    // var current_health = data.Get<float>(0);
    // var initial_health = data.Get<float>(1);

    // do something...
}
```

<br />
<br />

## 🟦 6. Remove the listeners :
To avoid memory leaks and unexpected behavior, remember to remove event listeners using the `RemoveListener` method when they're no longer needed. This also prevents listeners from being added twice when a scene reloads :
```c#
private void OnEnable() {
    // Add listener to the event :
    GEventsManager.AddListener(GEvents.EventName, EventCallback);
}

private void EventCallback(GData data) {
    // do something...
}

private void OnDisable() {
    // Remove the listener :
    GEventsManager.RemoveListener(GEvents.EventName, EventCallback);
}
```








<br><br>
<br><br>
## ❤️ Donate

<a href="https://paypal.me/hamzaherbou" title="https://paypal.me/hamzaherbou" target="_blank"><img align="left" height="50" src="https://www.mediafire.com/convkey/72dc/iz78ys7vtfsl957zg.jpg" alt="Paypal"></a>

# Unity Event Manager :

Add an Event System to your game in Unity to reduce dependencies and improve maintainability.
<br>

## 1. Add the ```Game_Events_Manager.unitypackage``` package to your game.
## 2. Define your events:
Go to the `Assets/Scripts/Game Events Manager/` and open the `GEvents.cs` script:
```c#
public enum GEvents {
    //Define the names of your events here ..
    Player_Health_Damaged,
    Player_Killed,
}
```

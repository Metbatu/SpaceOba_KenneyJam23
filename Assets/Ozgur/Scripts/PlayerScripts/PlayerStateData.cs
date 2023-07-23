using UnityEngine;

public class PlayerStateData : MonoBehaviour
{
    public enum PlayerMainState
    {
        NormalState,
        ShipControllingState,
    }

    [Header("Main State")]
    public PlayerMainState currentMainState = PlayerMainState.NormalState;

    [Header("States")]
    public bool isIdle;     //PlayerController.cs
    public bool isWalking;  //PlayerController.cs
    public bool isRunning;  //PlayerController.cs

    [Header("Logic Only Sub-states")]
    public bool isMoving;       //PlayerController.cs
    public bool isGrounded;     //GroundCheck.cs
    public bool isHooked;       //PlayerHookController.cs
    public bool isHookFlying;   //PlayerHookController.cs
}
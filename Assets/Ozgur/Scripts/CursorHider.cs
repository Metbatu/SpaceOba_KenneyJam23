using UnityEngine;

public class CursorHider : MonoBehaviour
{
    private PlayerStateData psd;
    public PlayerStateData.PlayerMainState previousState;

    private void Awake()
    {
        psd = GetComponent<PlayerStateData>();

        PauseMenu.OnGamePause += PauseGame;
        PauseMenu.OnGameContinue += ContinueGame;
    }

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void PauseGame()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        
        previousState = psd.currentMainState;
        psd.currentMainState = PlayerStateData.PlayerMainState.PauseMenuState;
    }

    private void ContinueGame()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
        psd.currentMainState = previousState;
    }
}
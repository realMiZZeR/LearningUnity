using UnityEngine;
using UnityEngine.UI;

public class MainMenu_Aside : CanvasPanel
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _charactersButton;
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _exitButton;

    private void Start()
    {
        
    }

    public void Exit()
    {
        Application.Quit();
    }
}

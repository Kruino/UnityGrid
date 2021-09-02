using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Quit : MonoBehaviour
{
    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btnR = yourButton.GetComponent<Button>();
        btnR.onClick.AddListener(doExitGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void doExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}

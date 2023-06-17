using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    float fps;
    float updateTimer;

    //Cread un texto en el canvas para asignarlo a esta variable y que muestre los fps
    [SerializeField] Text fpsText;

    // Update is called once per frame
    void Update()
    {
        UpdateFPS();
    }

    void UpdateFPS()
    {
        updateTimer -= Time.deltaTime;
        if(updateTimer <= 0)
        {
            fps = 1/ Time.deltaTime;
            fpsText.text = Mathf.Round(fps) + " FPS";
            updateTimer = 0.2f; 
        }
    }
}

using UnityEngine;

public class Sound : MonoBehaviour
{
    private bool soundOn = true;

    public void ToggleSound()
    {
        soundOn = !soundOn;

        AudioListener.volume = soundOn ? 1f : 0f;

        Debug.Log(soundOn ? "SES A�IK" : "SES KAPALI");
    }
}

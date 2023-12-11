using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagementDua : MonoBehaviour
{
    public void OnMusicButtonClicked()
    {
        SoundManagement.instance.PlayMusic();
    }

    public void OffMusicButtonClicked()
    {
        SoundManagement.instance.PauseMusic();
    }
}

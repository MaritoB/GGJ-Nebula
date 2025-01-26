using FMODUnity;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class VolumeControll : MonoBehaviour
{
    public Slider musicVolumeSlider;
    public Slider effectVolumeSlider;
    [Space]
    public StudioEventEmitter inflationSound;
    public StudioEventEmitter poppingSound;
    public StudioEventEmitter bubblingSound;
    public StudioEventEmitter beachEnviromentSound;
    public StudioEventEmitter menuMusic;
    public StudioEventEmitter in_gameMusic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Accionando los méetodos
        EffectModulation();
        MusicModulation();
    }
    public void EffectModulation() 
    {
        inflationSound.EventInstance.setVolume(effectVolumeSlider.value);
        poppingSound.EventInstance.setVolume(effectVolumeSlider.value);
        bubblingSound.EventInstance.setVolume(effectVolumeSlider.value);
        beachEnviromentSound.EventInstance.setVolume(effectVolumeSlider.value);
    }
    public void MusicModulation() 
    {
        menuMusic.EventInstance.setVolume(musicVolumeSlider.value);
        in_gameMusic.EventInstance.setVolume(musicVolumeSlider.value);
    }
}

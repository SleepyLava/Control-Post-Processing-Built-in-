using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class Post_Process_Settings : MonoBehaviour
{
    [SerializeField] PostProcessVolume postProcessVolume;

    Vignette vignette;
    AmbientOcclusion ambientOcc;
    DepthOfField depthOfField;
    Bloom bloom;
    ColorGrading colorGrading;

    // Start is called before the first frame update
    void Start()
    {
        postProcessVolume.profile.TryGetSettings(out vignette);
        postProcessVolume.profile.TryGetSettings(out ambientOcc);
        postProcessVolume.profile.TryGetSettings(out depthOfField);
        postProcessVolume.profile.TryGetSettings(out bloom);
        postProcessVolume.profile.TryGetSettings(out colorGrading);
    }

    public void PostProcessToggle(Toggle v)
    {
        postProcessVolume.gameObject.SetActive(v.isOn);
    }

    public void VignetteToggle(Toggle v)
    {
        vignette.active = v.isOn;
    }

    public void AmbientOcclusionToggle(Toggle v)
    {
        ambientOcc.active = v.isOn;
    }

    public void DepthOfFieldToggle(Toggle v)
    {
        depthOfField.active = v.isOn;
    }

    public void BloomToggle(Toggle v)
    {
        bloom.active = v.isOn;
    }

    public void ColorGradingToggle(Toggle v)
    {
        colorGrading.active = v.isOn;
    }
}

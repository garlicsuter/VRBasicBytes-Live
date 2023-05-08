using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class SoundToneController : MonoBehaviour
{
    public Slider slider;
    public float minFrequency = 100f;
    public float maxFrequency = 1000f;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        // Set the initial frequency based on the slider value
        SetFrequencyFromSliderValue(slider.value);
        // Add a listener for the slider value changed event
        slider.onValueChanged.AddListener(SetFrequencyFromSliderValue);
    }

    private void Update()
    {
        //Debug.Log("Slider Value: " + slider.value + " & Pitch: " + audioSource.pitch);
       // slider.onValueChanged(SetFrequencyFromSliderValue);
    }

    private void SetFrequencyFromSliderValue(float value)
    {
        // Calculate the new frequency based on the slider value
        float frequency = Mathf.Lerp(minFrequency, maxFrequency, value);
        // Set the new frequency on the audio source
        audioSource.pitch = frequency / audioSource.clip.length;
        Debug.Log("HELLOOO audiosource.pitch: " + audioSource.pitch + " & value: " + value);

    }
}


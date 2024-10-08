using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("----------- Audio Source -----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource effectSource;

    [Header("----------- Audio Clip -----------")]
    public AudioClip background;
    public AudioClip GameOver;
    public AudioClip hitting;
    public AudioClip BowShot;
    public AudioClip Walking;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlayEffect(AudioClip clip)
    {
        effectSource.PlayOneShot(clip);
    }
}

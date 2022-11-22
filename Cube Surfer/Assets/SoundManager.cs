using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    #region Singleton
    private static SoundManager instance = null;
    public static SoundManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("SoundManager").AddComponent<SoundManager>();
            }
            return instance;
        }
    }

    private void OnEnable()
    {
        instance = this;
    }

    #endregion
    AudioSource audioSource;
    [SerializeField] private AudioClip diamondCollectSound;
    private void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start() {
        audioSource = this.GetComponent<AudioSource>();
    }

    public void PlayDiamondSound()
    {
        audioSource.PlayOneShot(diamondCollectSound);
    }
}

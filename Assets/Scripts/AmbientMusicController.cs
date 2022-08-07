using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientMusicController : MonoBehaviour
{
    public AudioSource musicPlayer;
    public List<AudioClip> musicList;
    private int musicChoice;
    private float musicLength;
    private void Start()
    {
        StartCoroutine(playNextTrack());
    }

    private IEnumerator playNextTrack()
    {
        musicChoice = Random.Range(0, musicList.Capacity);
        musicPlayer.PlayOneShot(musicList[musicChoice]);
        musicLength = musicList[musicChoice].length;
        yield return new WaitForSeconds(musicLength);
        StartCoroutine(playNextTrack());
    }
}

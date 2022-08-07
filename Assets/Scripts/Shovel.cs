using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shovel : MonoBehaviour
{
    public AudioSource sFX;
    public List<AudioClip> sounds;
    private int soundChoice = 0;


    public float velocityThreshold;
    public float shovelocity;
    private bool onCooldown;
    private bool hit;
    [SerializeField] private Rigidbody shovelRb;

    private bool isGoodTreasure;

    private void Start()
    {
        onCooldown = false;
    }
    public Vector3 CheckVelocity()
    {
        return shovelRb.velocity;
    }
    private void OnTriggerEnter(Collider other)
    {
        soundChoice = Random.Range(0, sounds.Capacity);
        //Debug.Log($"Hits {other.gameObject.name}");
        Vector3 shovelVelocity = CheckVelocity();
        if (shovelVelocity.magnitude >= velocityThreshold && !onCooldown) hit = true;
        if (hit)
        {
            if (other.gameObject.CompareTag("TreasureSpot"))
            {
                isGoodTreasure = true;
                DigSpotCreator.instance.SpawnDigSpot(other.transform.position, isGoodTreasure);
                onCooldown = true;
                hit = false;
            }
            if (other.gameObject.CompareTag("DigSpot") || other.gameObject.CompareTag("DigSpotRad"))
            {
                other.gameObject.GetComponent<DigSpot>().digStage++;
                onCooldown = true;
                hit = false;
            }
            else if (other.gameObject.CompareTag("Ground"))
            {
                isGoodTreasure = false;
                DigSpotCreator.instance.SpawnDigSpot(transform.position, isGoodTreasure);
                onCooldown = true;
                hit = false;
            }
            sFX.PlayOneShot(sounds[soundChoice]);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        onCooldown = false;
    }
}

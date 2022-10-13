using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public int score = 0;
    public GameObject [] itemPrefab;
    public Transform leftTransform;
    public Transform rightTransform;

    public TextMeshPro scoreText;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        InvokeRepeating("SpawnItem",0,1);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text =  "Score: " + score.ToString();   
    }

    public void SpawnItem()
    {
        float randxValue = Random.Range(leftTransform.position.x, rightTransform.position.x);
        Vector2 spawnPos = new Vector2(randxValue, leftTransform.position.y);

        int index = Random.Range(0, itemPrefab.Length);
        Instantiate(itemPrefab[index], spawnPos, Quaternion.identity); 
    }

    public void IncrementScore(int value){
        score += value;
    }

    public void PlaySound(AudioClip clip){
        audioSource.PlayOneShot(clip);
    }


    
}
 
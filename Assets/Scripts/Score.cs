using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;
    float startOffset = 0f;

    // Start is called before the first frame update
    void Start()
    {
        startOffset = player.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.x - startOffset).ToString("0");
    }
}

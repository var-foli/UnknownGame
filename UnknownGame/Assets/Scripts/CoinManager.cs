using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class CoinManager : MonoBehaviour
{

    // coin effect
    private int coinCounter = 0;
    public TMP_Text coinText;
    public ParticleSystem coinEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "x " + coinCounter.ToString();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            // make coin disapear on collision
            gameObject.SetActive(false);
            coinCounter += 1;

            coinEffect.Play();
        }
    }
}

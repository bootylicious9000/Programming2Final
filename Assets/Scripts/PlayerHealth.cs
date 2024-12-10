using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int MaxHealth;
    public int Health;
    public TMP_Text HPText;

    // Start is called before the first frame update
    void Start()
    {
        Health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HPText.SetText("HP: "  + Health);

        if(Health == 0)
        {
            SceneManager.LoadScene("Game Over");
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Health--;
    }
}

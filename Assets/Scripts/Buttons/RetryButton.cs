using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{

    public Button Retry;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = Retry.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }
    
    void OnClick()
    {
        SceneManager.LoadScene("GameScene");
    }

}

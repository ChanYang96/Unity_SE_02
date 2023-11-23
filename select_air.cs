using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class select_air : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button selectair = GameObject.Find("select_air_button").GetComponent<Button>();
        Button selectlight = GameObject.Find("select_light_button").GetComponent<Button>();

        selectair.onClick.AddListener(OnairButtonClick);
        selectlight.onClick.AddListener(OnlightButtonClick);
    }

    void OnairButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void OnlightButtonClick()
    {
        SceneManager.LoadScene("lightScene");
    }
}
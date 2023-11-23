using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class go_main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button gomain = GameObject.Find("go_main_button").GetComponent<Button>();
        gomain.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        SceneManager.LoadScene("main_test_scene");
    }
}

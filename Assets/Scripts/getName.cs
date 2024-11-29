using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class getName : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        inputField.contentType = TMP_InputField.ContentType.Name;
    }
    private void Awake()
    {

    }
    public void ChangeScene()
    {
        PlayerPrefs.SetString("name", inputField.text);
        Debug.Log(PlayerPrefs.GetString("name"));
        SceneManager.LoadScene("PrincipalScene");
    }
    // Update is called once per frame
    void Update()
    {
    }
}

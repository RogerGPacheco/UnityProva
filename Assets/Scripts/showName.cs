using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class showName : MonoBehaviour
{
    public TMP_Text showname;
    // Start is called before the first frame update
    void Start()
    {
        showname.text = PlayerPrefs.GetString("name");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

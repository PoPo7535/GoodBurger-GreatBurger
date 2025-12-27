using System;
using System.ComponentModel;
using System.Linq;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScene : SetInspectorMonoBehaviour
{
    [ReadOnly] public Button startBtn;
    public override void SetInspector()
    {
        var child = transform.GetAllChild();
        startBtn = child.First(obj=> obj.name == "Start Btn").GetComponent<Button>();
    }

    public void Start()
    {
        startBtn.onClick.AddListener(()=>
        {
            SceneManager.LoadScene("GameScene");
        });
    }
}



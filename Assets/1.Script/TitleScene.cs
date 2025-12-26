using System;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScene : SetInspectorMonoBehaviour
{
    public Button startBtn;
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



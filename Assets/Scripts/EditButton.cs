using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EditButton : MonoBehaviour
{
    public void OnClicked()
    {
        SceneManager.LoadScene("EditScene");
    }
}

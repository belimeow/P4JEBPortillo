using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject titleScreen;

    StartGame()
    {
        titleScreen.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
}

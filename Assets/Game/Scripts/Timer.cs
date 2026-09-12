using System;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private TMP_Text timerText;
    private float _currentTIme = 0f;
    public bool isActive = true;

    void Start()
    {
        timerText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            _currentTIme = _currentTIme + Time.deltaTime;
            TimeSpan time = TimeSpan.FromSeconds(_currentTIme);

            timerText.text = time.ToString("mm':'ss");
        }
    }
}

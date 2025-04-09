using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MiniJeu : MonoBehaviour
{
    public float pointageTemps;
    [SerializeField] TextMeshProUGUI _Score;

    void Start()
    {
        pointageTemps = 0;
    }

    private void Update()
    {
        _Score.text = pointageTemps.ToString("00.00");
    }
}

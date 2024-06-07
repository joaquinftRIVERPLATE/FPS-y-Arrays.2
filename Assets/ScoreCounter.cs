using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    // Start is called before the first frame update

    public Text txtScore;
    public int Score;
    void Start()
    {
        txtScore.text = "0";
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        Score += alimento.valorAlimentario;
        txtScore.text = Score.ToString();
    }
}

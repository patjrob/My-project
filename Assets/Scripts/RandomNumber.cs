using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumber : MonoBehaviour {

    public Text numberText; 
    public int x;

    // Start is called before the first frame update
    void Start(){
        x=0;
    }

    // Update is called once per frame
    void Update(){
        numberText.text =x+"";
    }
    public void GenrateNumber(){
        x = Random.Range(0,12);
    }
}

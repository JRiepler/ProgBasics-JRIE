using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Operators();
        Scurr();
        Burr();
    }

     public void Operators()
    {
        Debug.Log("erste Tests mit Operatoren");

        //Multiplikative Operatoren
        Debug.Log("Multiplikative Operatoren: * " + (3 * 4));
        Debug.Log("Multiplikative Operatoren: / " + (9 / 3));
        Debug.Log("Multiplikative Operatoren: % " + (4 % 4));

        //Additive Operatoren
        Debug.Log("Additive Operatoren: + " + (3 + 4));
        Debug.Log("Additive Operatoren: - " + (4 - 3));

        //Relationale Operatoren
        Debug.Log("Relationale Operatoren: < " + (3 < 4));
        Debug.Log("Relationale Operatoren: <= " + (3 <= 4));
        Debug.Log("Relationale Operatoren: > " + (4 > 3));
        Debug.Log("Relationale Operatoren: >= " + (4 >= 3));

        //Gleichheits Operatoren
        Debug.Log("Gleichheits Operatoren: == " + (4 == 4));
        Debug.Log("Gleichheits Operatoren: != " + (3 != 4));

        //Logische Operatoren
        Debug.Log("Logische Operatoren: & " + (3 & 4));
        Debug.Log("Logische Operatoren: | " + (3 | 4));
    } 

    public void Scurr()
    {
        Debug.Log("Scurr");
    }

    public void Burr()
    {
        Debug.Log(100 + 87);
    }

    // Update is called once per frame
    void Update () {
		
	}
}

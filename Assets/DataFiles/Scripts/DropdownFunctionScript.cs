using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownFunctionScript : MonoBehaviour {
    List<string> chords = new List<string>() { "Open Chord", "Am", "C", "F", "G", "D", "A", "Dm", "B♭", "D7", "G7", "Em", "E7", "A7", "Bm", "C7", "B", "E", "E♭", "Fm", "Gm"};

    public GameObject a1, a2, a3, a4, c1, c2, c3, c4, e1, e2, e3, e4, g1, g2, g3, g4;
    //public Text atext, ctext, etext;
    public TextMesh atextmesh, ctextmesh, etextmesh, gtextmesh, afinmesh, cfinmesh, efinmesh, gfinmesh;

    public Dropdown dropdown;

    public void Dropdown_IndexChanged(int index) {
        ClearAll();

        if (index == 1){
            g2.SetActive(true);
            gtextmesh.text = "A";
            gfinmesh.text = "2";
        }
         else if (index == 2){
            a3.SetActive(true);
            atextmesh.text = "C";
            afinmesh.text = "3";
            }
        else if (index == 3)
        {
            g2.SetActive(true);
            e1.SetActive(true);
            gtextmesh.text = "A";
            etextmesh.text = "F";
            efinmesh.text = "1";
            gfinmesh.text = "2";
        }
        else if (index == 4)
        {
            c2.SetActive(true);
            e3.SetActive(true);
            a2.SetActive(true);
            ctextmesh.text = "D";
            etextmesh.text = "G";
            atextmesh.text = "B";
            cfinmesh.text = "1";
            efinmesh.text = "3";
            afinmesh.text = "2";
        }
        else if (index == 5)
        {
            g2.SetActive(true);
            c2.SetActive(true);
            e2.SetActive(true);
            gtextmesh.text = "A";
            ctextmesh.text = "D";
            etextmesh.text = "F#";
            gfinmesh.text = "1";
            cfinmesh.text = "2";
            efinmesh.text = "3";
            }
        else if (index == 6)
        {
            g2.SetActive(true);
            c1.SetActive(true);
            ctextmesh.text = "C#";
            gtextmesh.text = "A";
            gfinmesh.text = "2";
            cfinmesh.text = "1";
            }
        else if (index == 7)
        {
            g2.SetActive(true);
            c2.SetActive(true);
            e1.SetActive(true);
            ctextmesh.text = "D";
            etextmesh.text = "F";
            gtextmesh.text = "A";
            gfinmesh.text = "2";
            cfinmesh.text = "3";
            efinmesh.text = "1";
            }
        else if (index == 8)
        {
            g3.SetActive(true);
            c2.SetActive(true);
            e1.SetActive(true);
            a1.SetActive(true);
            atextmesh.text = "B♭";
            ctextmesh.text = "D";
            etextmesh.text = "F";
            gtextmesh.text = "B♭";
            gfinmesh.text = "3";
            cfinmesh.text = "2";
            efinmesh.text = "1";
            afinmesh.text = "1";
        }
        else if (index == 9)
        {
            g2.SetActive(true);
            c2.SetActive(true);
            e2.SetActive(true);
            a3.SetActive(true);
            atextmesh.text = "C";
            ctextmesh.text = "D";
            etextmesh.text = "F#";
            gtextmesh.text = "A";
            gfinmesh.text = "1";
            cfinmesh.text = "1";
            efinmesh.text = "1";
            afinmesh.text = "2";
        }
        else if (index == 10)
        {
            c2.SetActive(true);
            e1.SetActive(true);
            a2.SetActive(true);
            atextmesh.text = "B";
            ctextmesh.text = "D";
            etextmesh.text = "F";
            cfinmesh.text = "2";
            efinmesh.text = "1";
            afinmesh.text = "3";
        }
        else if (index == 11)
        {
            c4.SetActive(true);
            e3.SetActive(true);
            a2.SetActive(true);
            atextmesh.text = "B";
            ctextmesh.text = "E";
            etextmesh.text = "G";
            cfinmesh.text = "3";
            efinmesh.text = "2";
            afinmesh.text = "1";
        }
        else if (index == 12)
        {
            g1.SetActive(true);
            c2.SetActive(true);
            a2.SetActive(true);
            atextmesh.text = "B";
            ctextmesh.text = "D";
            gtextmesh.text = "G#";
            gfinmesh.text = "1";
            cfinmesh.text = "2";
            afinmesh.text = "3";
        }
        else if (index == 13)
        {
            c1.SetActive(true);
            ctextmesh.text = "C#";
            cfinmesh.text = "1";
            }
        else if (index == 14)
        {
            g4.SetActive(true);
            c2.SetActive(true);
            e2.SetActive(true);
            a2.SetActive(true);
            atextmesh.text = "B";
            ctextmesh.text = "D";
            etextmesh.text = "F#";
            gtextmesh.text = "B";
            gfinmesh.text = "3";
            cfinmesh.text = "1";
            efinmesh.text = "1";
            afinmesh.text = "1";
        }
        else if (index == 15)
        {
            a1.SetActive(true);
            atextmesh.text = "A#";
            afinmesh.text = "1";
            }
        else if (index == 16)
        {
            g4.SetActive(true);
            c3.SetActive(true);
            e2.SetActive(true);
            a2.SetActive(true);
            atextmesh.text = "B";
            ctextmesh.text = "D#";
            etextmesh.text = "F#";
            gtextmesh.text = "B";
            gfinmesh.text = "3";
            cfinmesh.text = "2";
            efinmesh.text = "1";
            afinmesh.text = "1";
        }
        else if (index == 17)
        {
            g4.SetActive(true);
            c4.SetActive(true);
            e4.SetActive(true);
            a2.SetActive(true);
            atextmesh.text = "B";
            ctextmesh.text = "E";
            etextmesh.text = "G#";
            gtextmesh.text = "B";
            gfinmesh.text = "2";
            cfinmesh.text = "3";
            efinmesh.text = "4";
            afinmesh.text = "1";
        }
        else if (index == 18)
        {
            c3.SetActive(true);
            e3.SetActive(true);
            a1.SetActive(true);
            atextmesh.text = "B♭";
            ctextmesh.text = "E♭";
            etextmesh.text = "G";
            cfinmesh.text = "3";
            efinmesh.text = "4";
            afinmesh.text = "1";
        }
        else if (index == 19)
        {
            g1.SetActive(true);
            e1.SetActive(true);
            a3.SetActive(true);
            atextmesh.text = "C";
            etextmesh.text = "F";
            gtextmesh.text = "G#";
            gfinmesh.text = "1";
            efinmesh.text = "2";
            afinmesh.text = "4";
        }
        else if (index == 20)
        {
            c2.SetActive(true);
            e3.SetActive(true);
            a1.SetActive(true);
            atextmesh.text = "A#";
            ctextmesh.text = "D";
            etextmesh.text = "G";
            cfinmesh.text = "2";
            efinmesh.text = "3";
            afinmesh.text = "1";
        }
    }

    void Start()
    {
        ClearAll();
        PopulateList();
    }

    void PopulateList(){     
        dropdown.AddOptions(chords);
    }

    void ClearAll(){
        a1.SetActive(false);
        a2.SetActive(false);
        a3.SetActive(false);
        a4.SetActive(false);
        c1.SetActive(false);
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(false);
        e1.SetActive(false);
        e2.SetActive(false);
        e3.SetActive(false);
        e4.SetActive(false);
        g1.SetActive(false);
        g2.SetActive(false);
        g3.SetActive(false);
        g4.SetActive(false);
        atextmesh.text = "A";
        ctextmesh.text = "C";
        etextmesh.text = "E";
        gtextmesh.text = "G";
        afinmesh.text = "";
        cfinmesh.text = "";
        efinmesh.text = "";
        gfinmesh.text = "";
    }
}

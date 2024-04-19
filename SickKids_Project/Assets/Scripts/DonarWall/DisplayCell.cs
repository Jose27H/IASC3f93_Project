using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;

using UnityEngine;

public class DisplayCell : MonoBehaviour
{
    private TextMeshProUGUI[] tmp1, tmp2, tmp3, tmp4, tmp5, tmp6, tmp7, tmp8, tmp9, tmp10, tmp11;
    public GameObject p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11;
    private int pCOunt1, pCount2 , pCount3, pCount4, pCount5, pCount6, pCount7, pCount8, pCount9, pCount10, pCount11 = 0;
    //int panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11;

    public List<string> lookup_id, Donor_Hall_Value, Donor_Hall_Amount, panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11 = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        StreamReader str = new StreamReader("./Assets/Scripts/DonarWall/Donor_List.csv");
        var line = str.ReadLine();
        while(!str.EndOfStream){
            line = str.ReadLine();
            var wrds = line.Split(',', 4);

            tmp1 = p1.GetComponentsInChildren<TextMeshProUGUI>();
            tmp2 = p2.GetComponentsInChildren<TextMeshProUGUI>();
            tmp3 = p3.GetComponentsInChildren<TextMeshProUGUI>();
            tmp4 = p4.GetComponentsInChildren<TextMeshProUGUI>();
            tmp5 = p5.GetComponentsInChildren<TextMeshProUGUI>();
            tmp6 = p6.GetComponentsInChildren<TextMeshProUGUI>();
            tmp7 = p7.GetComponentsInChildren<TextMeshProUGUI>();
            tmp8 = p8.GetComponentsInChildren<TextMeshProUGUI>();
            tmp9 = p9.GetComponentsInChildren<TextMeshProUGUI>();
            tmp10 = p10.GetComponentsInChildren<TextMeshProUGUI>();
            tmp11 = p11.GetComponentsInChildren<TextMeshProUGUI>();

            lookup_id.Add(wrds[0]);
            Donor_Hall_Value.Add(wrds[1]);
            Donor_Hall_Amount.Add(wrds[2]);
            var wrd = wrds[3].Split(':', 2);

            switch(wrd[0]){
                case "Panel 1":
                    panel1.Add(wrd[0]);
                    tmp1[pCOunt1].SetText(wrds[1]);
                    pCOunt1++;
                    break;

                case "Panel 2":
                    panel2.Add(wrd[0]);
                    tmp2[pCount2].SetText(wrds[1]);
                    pCount2++;
                    break;

                case "Panel 3":
                    panel3.Add(wrd[0]);
                    tmp3[pCount3].SetText(wrds[1]);
                    pCount3++;
                    break;

                case "Panel 4":
                    panel4.Add(wrd[0]);
                    tmp4[pCount4].SetText(wrds[1]);
                    pCount4++;
                    break; 

                case "Panel 5":
                    panel5.Add(wrd[0]);
                    tmp5[pCount5].SetText(wrds[1]);
                    pCount5++;
                    break;

                case "Panel 6":
                    panel6.Add(wrd[0]);
                    tmp6[pCount6].SetText(wrds[1]);
                    pCount6++;
                    break;

                case "Panel 7":
                    panel7.Add(wrd[0]);
                    tmp7[pCount7].SetText(wrds[1]);
                    pCount7++;
                    break;

                case "Panel 8":
                    panel8.Add(wrd[0]);
                    tmp8[pCount8].SetText(wrds[1]);
                    pCount8++;
                    break;

                case "Panel 9":
                    panel9.Add(wrd[0]);
                    tmp9[pCount9].SetText(wrds[1]);
                    pCount9++;
                    break;

                case "Panel 10":
                    panel10.Add(wrd[0]);
                    tmp10[pCount10].SetText(wrds[1]);
                    pCount10++;
                    break;

                case "Panel 11":
                    panel11.Add(wrd[0]);
                    tmp11[pCount11].SetText(wrds[1]);
                    pCount11++;
                    break;

                default:
                    Debug.Log(wrd[0]);
                    break;
            }
        }
        str.Close();

        TextMeshProUGUI[] tmp = GetComponentsInChildren<TextMeshProUGUI>();
        int i = 0;
        foreach (TextMeshProUGUI thing in tmp){
            if(thing.text.Equals("Muiz")){
                GameObject parent = thing.transform.parent.gameObject;
                GameObject.Destroy(parent.transform.parent.gameObject);
            }
        }
        
    }

    // Update is called once per frame
}

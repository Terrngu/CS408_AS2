using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CSVFileReader : MonoBehaviour
{

    public GameObject cubeTest;
    public GameObject cylinderTest;
    public TextAsset csvFile;
    public int i = 1;

    // Start is called before the first frame update
    void Start()
    {   
        InvokeRepeating("readCSV", 1f, 1f);  //1s delay, repeat every 1s
    }

    // Update is called once per frame
    void Update()
    {

        //readCSV();

    }

    void readCSV(){

        Debug.Log(Time.time);

        string [] records = csvFile.text.Split('\n');
        //for (int i = 1; i < records.Length; i++){
        string [] fields = records[i].Split(',');

            if(float.Parse(fields[0]) == 0 ){
                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                cubeTest.transform.position = newpos;

                //Update rotation
                cubeTest.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                cubeTest.transform.localScale += newscale;

                i++;
            }

            //if(float.Parse(fields[0]) == 1 ){
                //Update position
            //    Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
            //    cylinderTest.transform.position = newpos;

                //Update rotation
            //    cylinderTest.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));

                //Update scale
            //    Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
            //    cylinderTest.transform.localScale += newscale;
            //}
        }
    //}
}

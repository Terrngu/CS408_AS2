using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CSVFileReader : MonoBehaviour
{

    public GameObject ball_F1;
    public GameObject ball_F2;
    public GameObject ball_F3;
    public GameObject ball_F4;
    public GameObject ball_F5;
    public TextAsset csvFile;
    public int i = 1;

    // Start is called before the first frame update
    void Start()
    {   
        InvokeRepeating("readCSV", 0.06f, 0.06f);  //1s delay, repeat every 1s
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

            if(float.Parse(fields[1]) == 1){
                Vector3 resetpos = new Vector3(-100,0,0);
                ball_F2.transform.position = resetpos;
                ball_F3.transform.position = resetpos;
                ball_F4.transform.position = resetpos;
                ball_F5.transform.position = resetpos;

                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                ball_F1.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]));
                print("Positional Y: " + float.Parse(fields[3]));
                print("Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                ball_F1.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                ball_F1.transform.localScale += newscale;

                i++;
            }

            if(float.Parse(fields[1]) == 2){
                Vector3 resetpos = new Vector3(-100,0,0);
                ball_F1.transform.position = resetpos;
                ball_F3.transform.position = resetpos;
                ball_F4.transform.position = resetpos;
                ball_F5.transform.position = resetpos;

                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                ball_F2.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]));
                print("Positional Y: " + float.Parse(fields[3]));
                print("Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                ball_F2.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]));
                print("Rotational Y: " + float.Parse(fields[6]));
                print("Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                ball_F2.transform.localScale += newscale;

                i++;
            }

            if(float.Parse(fields[1]) == 3){
                Vector3 resetpos = new Vector3(-100,0,0);
                ball_F1.transform.position = resetpos;
                ball_F2.transform.position = resetpos;
                ball_F4.transform.position = resetpos;
                ball_F5.transform.position = resetpos;

                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                ball_F3.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]));
                print("Positional Y: " + float.Parse(fields[3]));
                print("Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                ball_F3.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]));
                print("Rotational Y: " + float.Parse(fields[6]));
                print("Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                ball_F3.transform.localScale += newscale;

                i++;
            }

            if(float.Parse(fields[1]) == 4){
                Vector3 resetpos = new Vector3(-100,0,0);
                ball_F1.transform.position = resetpos;
                ball_F2.transform.position = resetpos;
                ball_F3.transform.position = resetpos;
                ball_F5.transform.position = resetpos;

                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                ball_F4.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]));
                print("Positional Y: " + float.Parse(fields[3]));
                print("Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                ball_F4.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]));
                print("Rotational Y: " + float.Parse(fields[6]));
                print("Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                ball_F4.transform.localScale += newscale;

                i++;
            }

            if(float.Parse(fields[1]) == 5){
                Vector3 resetpos = new Vector3(-100,0,0);
                ball_F1.transform.position = resetpos;
                ball_F2.transform.position = resetpos;
                ball_F3.transform.position = resetpos;
                ball_F4.transform.position = resetpos;
                    
                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                ball_F5.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]));
                print("Positional Y: " + float.Parse(fields[3]));
                print("Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                ball_F5.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]));
                print("Rotational Y: " + float.Parse(fields[6]));
                print("Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                ball_F5.transform.localScale += newscale;
                print("Rotational X: " + float.Parse(fields[5]));
                print("Rotational Y: " + float.Parse(fields[6]));
                print("Rotational Z: " + float.Parse(fields[7]));

                i++;
            }

                
        }

    }

}

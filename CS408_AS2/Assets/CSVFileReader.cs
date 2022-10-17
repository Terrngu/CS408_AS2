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
    public GameObject cube_F1;
    public GameObject cube_F2;
    public GameObject cube_F3;
    public GameObject cube_F4;
    public GameObject cube_F5;
    public GameObject can_F1;
    public GameObject can_F2;
    public GameObject can_F3;
    public GameObject can_F4;
    public GameObject can_F5;
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
        //If user presses escape then end the program
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }

    void readCSV(){

        Debug.Log(Time.time);

        //Create array and include each line of the text file into the array
        string [] records = csvFile.text.Split('\n');

        //Create another array and include all inputs separated by a common, on each line, into the array
        string [] fields = records[i].Split(',');

        //Check if the object is spawning, running or despawning (1 for spawning, 2 for despawning, 0 for running)
        if(float.Parse(fields[11]) == 1){
            print("Object ID: " + float.Parse(fields[0]) + " does not exist.");
        }

        else if(float.Parse(fields[11]) == 2){
            print("Object ID: " + float.Parse(fields[0]) + " has left the screen, and does not exist.");
        }
        
        else{
            print ("Object ID: " + float.Parse(fields[0]));
        }

        print("Frame: " + float.Parse(fields[12]));

        //BALL REGISTERED
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
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                ball_F1.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

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
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                ball_F2.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

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
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                ball_F3.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

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
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                ball_F4.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

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
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                ball_F5.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                ball_F5.transform.localScale += newscale;

                i++;
            }

                
        }

        //CUBE REGISTERED
        else if(float.Parse(fields[0]) == 1 ){

            if(float.Parse(fields[1]) == 1){
                Vector3 resetpos = new Vector3(-100,0,0);
                cube_F2.transform.position = resetpos;
                cube_F3.transform.position = resetpos;
                cube_F4.transform.position = resetpos;
                cube_F5.transform.position = resetpos;

                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                cube_F1.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                cube_F1.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                cube_F1.transform.localScale += newscale;

                i++;
            }

            if(float.Parse(fields[1]) == 2){
                Vector3 resetpos = new Vector3(-100,0,0);
                cube_F1.transform.position = resetpos;
                cube_F3.transform.position = resetpos;
                cube_F4.transform.position = resetpos;
                cube_F5.transform.position = resetpos;

                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                cube_F2.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                cube_F2.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                cube_F2.transform.localScale += newscale;

                i++;
            }

            if(float.Parse(fields[1]) == 3){
                Vector3 resetpos = new Vector3(-100,0,0);
                cube_F1.transform.position = resetpos;
                cube_F2.transform.position = resetpos;
                cube_F4.transform.position = resetpos;
                cube_F5.transform.position = resetpos;

                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                cube_F3.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                cube_F3.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                cube_F3.transform.localScale += newscale;

                i++;
            }

            if(float.Parse(fields[1]) == 4){
                Vector3 resetpos = new Vector3(-100,0,0);
                cube_F1.transform.position = resetpos;
                cube_F2.transform.position = resetpos;
                cube_F3.transform.position = resetpos;
                cube_F5.transform.position = resetpos;

                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                cube_F4.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                cube_F4.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                cube_F4.transform.localScale += newscale;

                i++;
            }

            if(float.Parse(fields[1]) == 5){
                Vector3 resetpos = new Vector3(-100,0,0);
                cube_F1.transform.position = resetpos;
                cube_F2.transform.position = resetpos;
                cube_F3.transform.position = resetpos;
                cube_F4.transform.position = resetpos;
                    
                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                cube_F5.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                cube_F5.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                cube_F5.transform.localScale += newscale;

                i++;
            }

                
        }

        //CAN REGISTERED
        else if(float.Parse(fields[0]) == 2 ){

            if(float.Parse(fields[1]) == 1){
                Vector3 resetpos = new Vector3(-100,0,0);
                can_F2.transform.position = resetpos;
                can_F3.transform.position = resetpos;
                can_F4.transform.position = resetpos;
                can_F5.transform.position = resetpos;

                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                can_F1.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                can_F1.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                can_F1.transform.localScale += newscale;

                i++;
            }

            if(float.Parse(fields[1]) == 2){
                Vector3 resetpos = new Vector3(-100,0,0);
                can_F1.transform.position = resetpos;
                can_F3.transform.position = resetpos;
                can_F4.transform.position = resetpos;
                can_F5.transform.position = resetpos;

                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                can_F2.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                can_F2.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                can_F2.transform.localScale += newscale;

                i++;
            }

            if(float.Parse(fields[1]) == 3){
                Vector3 resetpos = new Vector3(-100,0,0);
                can_F1.transform.position = resetpos;
                can_F2.transform.position = resetpos;
                can_F4.transform.position = resetpos;
                can_F5.transform.position = resetpos;

                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                can_F3.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                can_F3.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                can_F3.transform.localScale += newscale;

                i++;
            }

            if(float.Parse(fields[1]) == 4){
                Vector3 resetpos = new Vector3(-100,0,0);
                can_F1.transform.position = resetpos;
                can_F2.transform.position = resetpos;
                can_F3.transform.position = resetpos;
                can_F5.transform.position = resetpos;

                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                can_F4.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                can_F4.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                can_F4.transform.localScale += newscale;

                i++;
            }

            if(float.Parse(fields[1]) == 5){
                Vector3 resetpos = new Vector3(-100,0,0);
                can_F1.transform.position = resetpos;
                can_F2.transform.position = resetpos;
                can_F3.transform.position = resetpos;
                can_F4.transform.position = resetpos;
                    
                //Update position
                Vector3 newpos = new Vector3(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
                can_F5.transform.position = newpos;
                print("Positional X: " + float.Parse(fields[2]) + ", Positional Y: " + float.Parse(fields[3]) + ", Positional Z: " + float.Parse(fields[4]));

                //Update rotation
                can_F5.transform.Rotate(float.Parse(fields[5]), float.Parse(fields[6]), float.Parse(fields[7]));
                print("Rotational X: " + float.Parse(fields[5]) + ", Rotational Y: " + float.Parse(fields[6]) + ", Rotational Z: " + float.Parse(fields[7]));

                //Update scale
                Vector3 newscale = new Vector3(float.Parse(fields[8]), float.Parse(fields[9]), float.Parse(fields[10]));
                can_F5.transform.localScale += newscale;

                i++;
            }

                
        }

    }

}

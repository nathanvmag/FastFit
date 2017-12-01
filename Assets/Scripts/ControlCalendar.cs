using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;

using System.Text;

public class ControlCalendar : MonoBehaviour {
    [SerializeField]
    GameObject horarioprefab;
    bool[,] serializedsValues;
    bool firstCLick;
    // Use this for initialization
    void Start()
    {
        firstCLick = false;
        serializedsValues = new bool[7, 24];
        Debug.Log(serializedsValues.GetLength(1));
    }
    // Update is called once per frame
    void Update() {
     
    }

    public void clickHorario(GameObject gb)
    {
        if (!firstCLick)
        {
            try
            {
                serializedsValues = JsonConvert.DeserializeObject<bool[,]>(read()) ;
               
                Debug.Log("Pegou do save");
            }
            catch (System.Exception e)
            {
                Debug.Log("nao tem save"+ e.ToString());

                serializedsValues = new bool[7, 24];
                for (int i = 0; i < gb.GetComponent<dayweek>().values.Length; i++)
                {
                    gb.GetComponent<dayweek>().values[i] = false;
                }

                for (int i = 0; i < serializedsValues.GetLength(0); i++)
                {
                    for (int j = 0; j < serializedsValues.GetLength(1); j++)
                    {
                        serializedsValues[i, j] = false;
                    }
                }
                save (JsonConvert.SerializeObject(serializedsValues));

                
            }
        }
        firstCLick = true;
        GameObject father = GameObject.FindGameObjectWithTag("calendarContent");
        if (!gb.GetComponent<dayweek>().isOpen)
        {

            for (int i = 0; i < serializedsValues.GetLength(1); i++)
            {
                gb.GetComponent<dayweek>().values[i] = serializedsValues[int.Parse(gb.name), i];

            }
            GameObject horario = Instantiate(horarioprefab, father.transform.position, Quaternion.identity, father.transform) as GameObject;
            father.GetComponent<RectTransform>().sizeDelta += new Vector2(0, 276);
            horario.transform.SetSiblingIndex(gb.transform.GetSiblingIndex() + 1);
            int child = 0;
            foreach (Transform t in horario.transform)
            {
                t.GetComponent<Toggle>().isOn = gb.GetComponent<dayweek>().values[child];
                child++;
            }

        }
        else
        {
            Destroy(father.transform.GetChild(gb.transform.GetSiblingIndex() + 1).gameObject);
            father.GetComponent<RectTransform>().sizeDelta += new Vector2(0, -276);
            write(gb.GetComponent<dayweek>().values, int.Parse(gb.name));
        }
        gb.GetComponent<dayweek>().isOpen = !gb.GetComponent<dayweek>().isOpen;
    }
    void write(bool[] values, int index)
    {
        for (int i = 0; i < serializedsValues.GetLength(1); i++)
        {
            serializedsValues[index, i] = values[i];
        }
        save(JsonConvert.SerializeObject(serializedsValues));
    }
    void save(string serialized)
    {
        Debug.Log("Salvou  assim" + serialized);

        if (!Directory.Exists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/FastFit"))
        {
            Directory.CreateDirectory(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/FastFit");
        }
      string filePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments)+ "/FastFit/options.txt";
        if (File.Exists(filePath)) File.Delete(filePath);
        using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(filePath, true))
        {
            
            file.WriteLine(serialized);
        }
    }
    string read ()
    {
        if (!Directory.Exists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/FastFit"))
        {
            Directory.CreateDirectory(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/FastFit");
        }
        string filePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments)+ "/FastFit/options.txt";
        try
        {
            if (File.Exists(filePath))

            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    
                    // Read the stream to a string, and write the string to the console.
                    string line = sr.ReadToEnd();
                    Debug.Log("leu assim" + line);
                    return line;
                }
            }
            return "";
        }
        catch
        {
            return "";
        }
    }
}


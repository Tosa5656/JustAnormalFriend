using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Save : MonoBehaviour
{
    public void CreateSave()
    {
        FileInfo file = new FileInfo("save.txt");
        file.Create();
    }
}

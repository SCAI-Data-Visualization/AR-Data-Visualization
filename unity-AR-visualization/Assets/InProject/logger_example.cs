using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using UnityEngine;

#if WINDOWS_UWP
using Windows.Storage;
using Windows.Storage.Pickers;
#endif

public class Logger : MonoBehaviour
{
    StreamWriter logFileWriter;

    private string FileName;

    private bool Recording;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!this.Recording)
        {
            return;
        }

        string record = DateTime.Now + "," +
                Camera.main.transform.position.x + "," +
                Camera.main.transform.position.y + "," +
                Camera.main.transform.position.z + "," +
                Camera.main.transform.rotation.x + "," +
                Camera.main.transform.rotation.y + "," +
                Camera.main.transform.rotation.z;

        if (this.logFileWriter != null)
        {
            this.logFileWriter.WriteLine(record);
        }
    }

    public void RecordNewTrial(string teamName, string trialName)
    {
        if (!this.Recording)
        {
            this.StartCoroutine(this.SetupRecording(teamName, trialName));
        }
        else
        {
            string header = "NEW TRIAL," + trialName + "," + DateTime.Now;

            if (this.logFileWriter != null)
            {
                this.logFileWriter.WriteLine(header);
            }
        }
    }

    private IEnumerator SetupRecording(string teamName, string trialName)
    {
        this.FileName = teamName + "_datalog_" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".csv";

        bool asyncOperationDone = false;
        UnityEngine.WSA.Application.InvokeOnUIThread(async () =>
        {
            await this.PickLogSaveLocationAsync();
            asyncOperationDone = true;
        }, true);

#if WINDOWS_UWP
        // See https://blog.mzikmund.com/2020/01/how-to-stream-ify-a-uwp-storagefile/
        // Also see https://forums.hololens.com/discussion/comment/7133/#Comment_7133
        // And finally see https://forums.hololens.com/discussion/3290/save-a-string-to-a-text-or-cvs-file-on-hololens
#else
        this.logFileWriter = null;
        Debug.Log("UWP not detected. No data logging will proceed.");
#endif

        while (!asyncOperationDone)
        {
            yield return null;
        }

        string header = "NEW TRIAL," + trialName + "," + DateTime.Now;

        if (this.logFileWriter != null)
        {
            this.logFileWriter.WriteLine(header);
        }

        this.Recording = true;
    }

    /// <summary>
    /// Closes the log file writer. This is important to prevent this program from locking the file
    /// even after it is done.
    /// </summary>
    public void CloseLogFile()
    {
        if (this.logFileWriter != null)
        {
            this.logFileWriter.Close();
        }
    }

    private async Task PickLogSaveLocationAsync()
    {
#if WINDOWS_UWP
        FileSavePicker savePicker = new FileSavePicker();
        savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
        savePicker.FileTypeChoices.Add("CSV", new List<string>() { ".csv" });
        savePicker.SuggestedFileName = this.FileName;

        StorageFile file = await savePicker.PickSaveFileAsync();
        if (file != null)
        {
            Stream fileStream = await file.OpenStreamForWriteAsync();
            this.logFileWriter = new StreamWriter(fileStream);
        }
#endif
    }
}
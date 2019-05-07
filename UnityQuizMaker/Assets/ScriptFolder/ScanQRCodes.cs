using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//

    // Cards => Für jede Antwortmöglichkeit für jedes Team
    // 4 Cards for each Team / TeamName A / TeamName B / TeamName C / TeamName D
    // 20 Teams (angenommen)
    // == 80 QR Codes (Erstellen ist kein Problem aber zeitaufwendig)
    // Wichtig! Die Teamnamen müssen vorher bekannt sein, oder die Teamnamen sind Variablen, die vor beginn geändert werden (Via Eingabefunktion)

//

public class ScanQRCodes : MonoBehaviour {
    public void Update()
    {
        GetQRCode();
        DebugItVisual(); // Soll immer aktuell sein / IEnumerator
    }
    void GetQRCode() // We need a QRCode which the TeamName and the Letters A/B/C/D foreach
    {
        //Cooldown thad the same "Card" cannot get scanned twice / a Timerfunction could fix this
        //Get Message A/B/C/D from String
        //Get Team (TeamName) from String
        //Get Actual Round (Round 1, 2 ... for Points) from RoundCounter (Int)
        //Write it on a sheet (.txt)
        //Debug it in the Console
        //Debug it visual;
        ///
        /// 
        /// 
        /// DebugItVisual();
    }
    public void DebugItVisual()
    {
        //For each point Instantiate a Cube for the right Team in order
        //Scale them thad it fits which even 3 points and 50 as well
        //Die  Cubes sind immer alle gleichgroß
    }
}

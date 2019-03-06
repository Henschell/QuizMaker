using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Question : MonoBehaviour {

    [SerializeField] private string _info = string.Empty;
    public string Info { get { return _info; } }
}

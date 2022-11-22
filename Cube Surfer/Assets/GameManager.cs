using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Singleton
    private static GameManager instance = null;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return instance;
        }
    }

    private void OnEnable()
    {
        instance = this;
    }

    #endregion
    [SerializeField] private GameObject _floor;
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private GameObject _player;
    private int _score = 0;
    
    // private void Start() {
    //     DontDestroyOnLoad(this.gameObject);
    // }
    public float[] floorXBounds => new float[]{this._floor.GetComponent<MeshRenderer>().bounds.min.x, this._floor.GetComponent<MeshRenderer>().bounds.max.x};
    public float cubeWidth => this._cubePrefab.GetComponent<BoxCollider>().size.x;
    public GameObject player => this._player;
    public int Score{get{return this._score;} set{this._score = value;}}
    

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }
}

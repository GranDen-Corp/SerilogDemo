using System.Collections;
using System.Collections.Generic;
using SerilogUnity3dSink;
using UnityEngine;
using Logger = Serilog.Core.Logger;

public class MainPlayer : MonoBehaviour {
	private Logger _logger;

	public MainPlayer()
	{
		_logger = new Serilog.LoggerConfiguration().WriteTo.UnityConsole().CreateLogger();
	}

	// Use this for initialization
	void Start () {
		Debug.Log("Start MainPlayer");
	}
	
	// Update is called once per frame
	void Update () {
		_logger.Information("call update");
	}
}

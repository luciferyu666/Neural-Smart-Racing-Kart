///////////////////////////////////////////////////////////
//  Drive.cs
//  Implementation of the Class Drive
//  Generated by Enterprise Architect
//  Created on:      23-�Q�G��-2018 �U�� 06:24:27
//  Original author: satan
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



public class Drive : MonoBehaviour {

	private List<string> collectedTrainingData = new List<string>();
	public float rotationSpeed = 100.0F;
	public float speed = 50.0F;
	private StreamWriter tdf;
	public float visibleDistance = 200.0f;

	public Drive(){

	}

	~Drive(){

	}

	private void OnApplicationQuit(){

	}

	/// 
	/// <param name="x"></param>
	private float Round(float x){

		return 0;
	}

	private void Start(){

	}

	private void Update(){

	}

}//end Drive
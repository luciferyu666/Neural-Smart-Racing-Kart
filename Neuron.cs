///////////////////////////////////////////////////////////
//  Neuron.cs
//  Implementation of the Class Neuron
//  Generated by Enterprise Architect
//  Created on:      23-�Q�G��-2018 �U�� 06:24:27
//  Original author: satan
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



public class Neuron {

	public double bias;
	public double errorGradient;
	public List<double> inputs = new List<double>();
	public int numInputs;
	public double output;
	public List<double> weights = new List<double>();

	public Neuron(){

	}

	~Neuron(){

	}

	/// 
	/// <param name="nInputs"></param>
	public Neuron(int nInputs){

	}

}//end Neuron
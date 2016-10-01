//using System;
using System.Collections;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.IO;
//using System.Reflection;
//using System.Runtime;
using KSP;
using KSP.IO;
using UnityEngine;

namespace scatterer
{
	public class planetsListReader
	{
		[Persistent]
		public List < scattererCelestialBody > scattererCelestialBodies = new List < scattererCelestialBody > {};

		[Persistent]
		public List<planetShineLightSource> celestialLightSourcesData=new List<planetShineLightSource> {};

		public void loadPlanetsList ()
		{
			ConfigNode[] confNodes = GameDatabase.Instance.GetConfigNodes ("Scatterer_planetsList");
			Debug.Log (confNodes.Length.ToString ());
			if (confNodes.Length == 0) {
				Debug.Log ("[Scatterer] No planetsList file found, check your install");
				return;
			}
			
			if (confNodes.Length > 1) {
				Debug.Log ("[Scatterer] Multiple planetsList files detected, check your install");
			}

			ConfigNode.LoadObjectFromConfig (this, confNodes [0]);
		}
	}
}


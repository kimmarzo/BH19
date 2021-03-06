﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Target that sends events when hit by an arrow
//
//=============================================================================

using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;


namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class yesCube : MonoBehaviour
	{
        public ParticleSystem explosion;
		public bool onceOnly = false;
		public Transform targetCenter;
        public GameObject destroythis;
		public Transform baseTransform;
		public Transform fallenDownTransform;
		public float fallTime = 0.5f;
        public GameObject parentWhole;
		const float targetRadius = 0.25f;
        public GameObject spawner;

		private bool targetEnabled = true;


		//-------------------------------------------------
		private void ApplyDamage()
		{
			OnDamageTaken();
		}


		//-------------------------------------------------
		private void FireExposure()
		{
			OnDamageTaken();
           
		}


		//-------------------------------------------------
		private void OnDamageTaken()
		{
            explosion.Emit(100);
            spawner.SetActive(false);
            Destroy(destroythis);
            SceneManager.LoadScene(0);
            //if ( targetEnabled )
            //{
            //	onTakeDamage.Invoke();
            //	StartCoroutine( this.FallDown() );

            //	if ( onceOnly )
            //	{
            //		targetEnabled = false;
            //	}
            //}
        }


		////-------------------------------------------------
		//private IEnumerator FallDown()
		//{
		//	if ( baseTransform )
		//	{
		//		Quaternion startingRot = baseTransform.rotation;

		//		float startTime = Time.time;
		//		float rotLerp = 0f;

		//		while ( rotLerp < 1 )
		//		{
		//			rotLerp = Util.RemapNumberClamped( Time.time, startTime, startTime + fallTime, 0f, 1f );
		//			baseTransform.rotation = Quaternion.Lerp( startingRot, fallenDownTransform.rotation, rotLerp );
		//			yield return null;
		//		}
		//	}

		//	yield return null;
		//}
	}
}

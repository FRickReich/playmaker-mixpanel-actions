using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Mixpanel")]
	[Tooltip("Setup Mixpanel For Unity")]
	public class SetupMixpanel : FsmStateAction
	{
		
		[Tooltip("Set this to your Mixpanel token.")]
		[RequiredField]
		public string Token;

		[Tooltip("Set this to the distinct ID of the current user.")]
		public string DistinctID;

		[Tooltip("Set to true to send user platform informations to mixpanel.")]
		public FsmBool SendUserProperties;

		public override void Reset()
		{
			Token = null;
			DistinctID = "";
			SendUserProperties = false;
		}
		
		public override void OnEnter()
		{
			
			if (Token!=null)
			{
				if(SendUserProperties.Value == true) {
					Mixpanel.SuperProperties.Add("platform", Application.platform.ToString());
					Mixpanel.SuperProperties.Add("resolution", Screen.width + "x" + Screen.height);
				}

				Mixpanel.Token = Token;
				Mixpanel.DistinctID = DistinctID;
			}
			
			Finish();
			
		}

	}
}
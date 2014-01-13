using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions {
	
	[ActionCategory("Mixpanel")]
	[Tooltip("Mixpanel Quaternion Event")]

	public class  MixpanelQuaternionEvent : FsmStateAction {

		[RequiredField]
		public string EventName;
		
		[RequiredField]
		public FsmString QuaternionName;

		public FsmQuaternion QuaternionValue;
		
		public override void Reset()
		{
			EventName = null;
			QuaternionName = "";
			QuaternionValue = null;
		}
		
		public override void OnEnter() {

			Mixpanel.SendEvent(EventName, new Dictionary<string, object> {
				{QuaternionName.ToString(), QuaternionValue.ToString()}
			});
			
			Finish();
			
		}
	}
}


using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions {
	
	[ActionCategory("Mixpanel")]
	[Tooltip("Mixpanel Rect Event")]

	public class  MixpanelRectEvent : FsmStateAction {

		[RequiredField]
		public string EventName;
		
		[RequiredField]
		public FsmString RectName;

		public FsmRect RectValue;
		
		public override void Reset()
		{
			EventName = null;
			RectName = "";
			RectValue = null;
		}
		
		public override void OnEnter() {

			Mixpanel.SendEvent(EventName, new Dictionary<string, object> {
				{RectName.ToString(), RectValue.ToString()}
			});
			
			Finish();
			
		}
	}
}


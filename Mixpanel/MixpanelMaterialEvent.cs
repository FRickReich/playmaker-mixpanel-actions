using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions {
	
	[ActionCategory("Mixpanel")]
	[Tooltip("Mixpanel Material Event")]

	public class  MixpanelMaterialEvent : FsmStateAction {

		[RequiredField]
		public string EventName;
		
		[RequiredField]
		public FsmString MaterialName;

		public FsmMaterial MaterialValue;
		
		public override void Reset()
		{
			EventName = null;
			MaterialName = "";
			MaterialValue = null;
		}
		
		public override void OnEnter() {

			Mixpanel.SendEvent(EventName, new Dictionary<string, object> {
				{MaterialName.ToString(), MaterialValue.ToString()}
			});
			
			Finish();
			
		}
	}
}


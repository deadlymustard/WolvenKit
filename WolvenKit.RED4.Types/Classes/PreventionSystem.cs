using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("districtManager")] 
		public CHandle<DistrictManager> DistrictManager
		{
			get => GetPropertyValue<CHandle<DistrictManager>>();
			set => SetPropertyValue<CHandle<DistrictManager>>(value);
		}

		[Ordinal(1)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(2)] 
		[RED("preventionPreset")] 
		public CWeakHandle<gamedataDistrictPreventionData_Record> PreventionPreset
		{
			get => GetPropertyValue<CWeakHandle<gamedataDistrictPreventionData_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataDistrictPreventionData_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("hiddenReaction")] 
		public CBool HiddenReaction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("systemDisabled")] 
		public CBool SystemDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("systemLockSources")] 
		public CArray<CName> SystemLockSources
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("deescalationZeroLockExecution")] 
		public CBool DeescalationZeroLockExecution
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("heatStage")] 
		public CEnum<EPreventionHeatStage> HeatStage
		{
			get => GetPropertyValue<CEnum<EPreventionHeatStage>>();
			set => SetPropertyValue<CEnum<EPreventionHeatStage>>(value);
		}

		[Ordinal(8)] 
		[RED("playerIsInSecurityArea")] 
		public CArray<gamePersistentID> PlayerIsInSecurityArea
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		[Ordinal(9)] 
		[RED("policeSecuritySystems")] 
		public CArray<gamePersistentID> PoliceSecuritySystems
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		[Ordinal(10)] 
		[RED("policeman100SpawnHits")] 
		public CInt32 Policeman100SpawnHits
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("agentGroupsList")] 
		public CArray<CHandle<PreventionAgents>> AgentGroupsList
		{
			get => GetPropertyValue<CArray<CHandle<PreventionAgents>>>();
			set => SetPropertyValue<CArray<CHandle<PreventionAgents>>>(value);
		}

		[Ordinal(12)] 
		[RED("agentsWhoSeePlayer")] 
		public CArray<entEntityID> AgentsWhoSeePlayer
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(13)] 
		[RED("hitNPC")] 
		public CArray<SHitNPC> HitNPC
		{
			get => GetPropertyValue<CArray<SHitNPC>>();
			set => SetPropertyValue<CArray<SHitNPC>>(value);
		}

		[Ordinal(14)] 
		[RED("spawnedAgents")] 
		public CArray<CWeakHandle<ScriptedPuppet>> SpawnedAgents
		{
			get => GetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>(value);
		}

		[Ordinal(15)] 
		[RED("lastCrimePoint")] 
		public Vector4 LastCrimePoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(16)] 
		[RED("lastBodyPosition")] 
		public Vector4 LastBodyPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(17)] 
		[RED("DEBUG_lastCrimeDistance")] 
		public CFloat DEBUG_lastCrimeDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("policemanRandPercent")] 
		public CInt32 PolicemanRandPercent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("policemabProbabilityPercent")] 
		public CInt32 PolicemabProbabilityPercent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("generalPercent")] 
		public CFloat GeneralPercent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("partGeneralPercent")] 
		public CFloat PartGeneralPercent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("newDamageValue")] 
		public CFloat NewDamageValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("gameTimeStampPrevious")] 
		public CFloat GameTimeStampPrevious
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("gameTimeStampLastPoliceRise")] 
		public CFloat GameTimeStampLastPoliceRise
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("gameTimeStampDeescalationZero")] 
		public CFloat GameTimeStampDeescalationZero
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("deescalationZeroDelayID")] 
		public gameDelayID DeescalationZeroDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(27)] 
		[RED("deescalationZeroCheck")] 
		public CBool DeescalationZeroCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("policemenSpawnDelayID")] 
		public gameDelayID PolicemenSpawnDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(29)] 
		[RED("preventionTickDelayID")] 
		public gameDelayID PreventionTickDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(30)] 
		[RED("preventionTickCheck")] 
		public CBool PreventionTickCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("securityAreaResetDelayID")] 
		public gameDelayID SecurityAreaResetDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(32)] 
		[RED("securityAreaResetCheck")] 
		public CBool SecurityAreaResetCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("hadOngoingSpawnRequest")] 
		public CBool HadOngoingSpawnRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("Debug_PorcessReason")] 
		public CEnum<EPreventionDebugProcessReason> Debug_PorcessReason
		{
			get => GetPropertyValue<CEnum<EPreventionDebugProcessReason>>();
			set => SetPropertyValue<CEnum<EPreventionDebugProcessReason>>(value);
		}

		[Ordinal(35)] 
		[RED("Debug_PsychoLogicType")] 
		public CEnum<EPreventionPsychoLogicType> Debug_PsychoLogicType
		{
			get => GetPropertyValue<CEnum<EPreventionPsychoLogicType>>();
			set => SetPropertyValue<CEnum<EPreventionPsychoLogicType>>(value);
		}

		[Ordinal(36)] 
		[RED("currentPreventionPreset")] 
		public TweakDBID CurrentPreventionPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(37)] 
		[RED("failsafePoliceRecordT1")] 
		public TweakDBID FailsafePoliceRecordT1
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(38)] 
		[RED("failsafePoliceRecordT2")] 
		public TweakDBID FailsafePoliceRecordT2
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(39)] 
		[RED("failsafePoliceRecordT3")] 
		public TweakDBID FailsafePoliceRecordT3
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(40)] 
		[RED("blinkReasonsStack")] 
		public CArray<CName> BlinkReasonsStack
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(41)] 
		[RED("wantedBarBlackboard")] 
		public CWeakHandle<gameIBlackboard> WantedBarBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(42)] 
		[RED("onPlayerChoiceCallID")] 
		public CHandle<redCallbackObject> OnPlayerChoiceCallID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(43)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(44)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(45)] 
		[RED("playerHLSID")] 
		public CHandle<redCallbackObject> PlayerHLSID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(46)] 
		[RED("playerVehicleStateID")] 
		public CHandle<redCallbackObject> PlayerVehicleStateID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(47)] 
		[RED("playerHLS")] 
		public CEnum<gamePSMHighLevel> PlayerHLS
		{
			get => GetPropertyValue<CEnum<gamePSMHighLevel>>();
			set => SetPropertyValue<CEnum<gamePSMHighLevel>>(value);
		}

		[Ordinal(48)] 
		[RED("playerVehicleState")] 
		public CEnum<gamePSMVehicle> PlayerVehicleState
		{
			get => GetPropertyValue<CEnum<gamePSMVehicle>>();
			set => SetPropertyValue<CEnum<gamePSMVehicle>>(value);
		}

		[Ordinal(49)] 
		[RED("currentStageFallbackUnitSpawned")] 
		public CBool CurrentStageFallbackUnitSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("unhandledInputsReceived")] 
		public CInt32 UnhandledInputsReceived
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(51)] 
		[RED("inputlockDelayID")] 
		public gameDelayID InputlockDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(52)] 
		[RED("preventionUnitKilledDuringLock")] 
		public CBool PreventionUnitKilledDuringLock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("reconDeployed")] 
		public CBool ReconDeployed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("vehicles")] 
		public CArray<CWeakHandle<vehicleBaseObject>> Vehicles
		{
			get => GetPropertyValue<CArray<CWeakHandle<vehicleBaseObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<vehicleBaseObject>>>(value);
		}

		[Ordinal(55)] 
		[RED("viewers")] 
		public CArray<CWeakHandle<gameObject>> Viewers
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameObject>>>(value);
		}

		[Ordinal(56)] 
		[RED("hasViewers")] 
		public CBool HasViewers
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PreventionSystem()
		{
			SystemLockSources = new();
			PlayerIsInSecurityArea = new();
			PoliceSecuritySystems = new();
			AgentGroupsList = new();
			AgentsWhoSeePlayer = new();
			HitNPC = new();
			SpawnedAgents = new();
			LastCrimePoint = new();
			LastBodyPosition = new();
			DeescalationZeroDelayID = new();
			PolicemenSpawnDelayID = new();
			PreventionTickDelayID = new();
			SecurityAreaResetDelayID = new();
			BlinkReasonsStack = new();
			InputlockDelayID = new();
			Vehicles = new();
			Viewers = new();
		}
	}
}

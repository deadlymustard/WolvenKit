using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RainMissileProjectile : BaseProjectile
	{
		[Ordinal(51)] 
		[RED("meshComponent")] 
		public CHandle<entIComponent> MeshComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(52)] 
		[RED("effect")] 
		public gameEffectRef Effect
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(53)] 
		[RED("damage")] 
		public CHandle<gameEffectInstance> Damage
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(54)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(55)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(56)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("lifetime")] 
		public CFloat Lifetime_528
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("hit")] 
		public CBool Hit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("arrived")] 
		public CBool Arrived
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("spawnPosition")] 
		public Vector4 SpawnPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(63)] 
		[RED("phase1Duration")] 
		public CFloat Phase1Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(64)] 
		[RED("landIndicatorFX")] 
		public gameFxResource LandIndicatorFX
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(65)] 
		[RED("fxInstance")] 
		public CHandle<gameFxInstance> FxInstance
		{
			get => GetPropertyValue<CHandle<gameFxInstance>>();
			set => SetPropertyValue<CHandle<gameFxInstance>>(value);
		}

		[Ordinal(66)] 
		[RED("hasExploded")] 
		public CBool HasExploded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("missileDBID")] 
		public TweakDBID MissileDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(68)] 
		[RED("missileAttackRecord")] 
		public CWeakHandle<gamedataAttack_Record> MissileAttackRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAttack_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAttack_Record>>(value);
		}

		[Ordinal(69)] 
		[RED("timeToDestory")] 
		public CFloat TimeToDestory
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(70)] 
		[RED("initialTargetPosition")] 
		public Vector4 InitialTargetPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(71)] 
		[RED("initialTargetOffset")] 
		public Vector4 InitialTargetOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(72)] 
		[RED("finalTargetPosition")] 
		public Vector4 FinalTargetPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(73)] 
		[RED("finalTargetOffset")] 
		public Vector4 FinalTargetOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(74)] 
		[RED("finalTargetPositionCalculationDelay")] 
		public CFloat FinalTargetPositionCalculationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(75)] 
		[RED("targetComponent")] 
		public CWeakHandle<entIPlacedComponent> TargetComponent
		{
			get => GetPropertyValue<CWeakHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CWeakHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(76)] 
		[RED("followTargetInPhase2")] 
		public CBool FollowTargetInPhase2
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(77)] 
		[RED("puppetBroadphaseHitRadiusSquared")] 
		public CFloat PuppetBroadphaseHitRadiusSquared
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(78)] 
		[RED("phase")] 
		public CEnum<EMissileRainPhase> Phase
		{
			get => GetPropertyValue<CEnum<EMissileRainPhase>>();
			set => SetPropertyValue<CEnum<EMissileRainPhase>>(value);
		}

		[Ordinal(79)] 
		[RED("spiralParams")] 
		public CHandle<gameprojectileSpiralParams> SpiralParams
		{
			get => GetPropertyValue<CHandle<gameprojectileSpiralParams>>();
			set => SetPropertyValue<CHandle<gameprojectileSpiralParams>>(value);
		}

		[Ordinal(80)] 
		[RED("useSpiralParams")] 
		public CBool UseSpiralParams
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(81)] 
		[RED("randStartVelocity")] 
		public CFloat RandStartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public RainMissileProjectile()
		{
			Effect = new();
			Alive = true;
			SpawnPosition = new();
			LandIndicatorFX = new();
			TimeToDestory = -1.000000F;
			InitialTargetPosition = new();
			InitialTargetOffset = new();
			FinalTargetPosition = new();
			FinalTargetOffset = new();
		}
	}
}

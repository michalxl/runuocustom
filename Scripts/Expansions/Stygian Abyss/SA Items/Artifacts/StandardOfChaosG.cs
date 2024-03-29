using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
    [FlipableAttribute(0x904, 0x406D)]
    public class StandardOfChaosG : DualPointedSpear //TODO: DoubleBladedSpear
	{

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public StandardOfChaosG()
		{
			Name = ("Standard Of Chaos");
		
			Hue = 2209;
			
		WeaponAttributes.HitHarm = 30;	
		WeaponAttributes.HitFireball = 20;	
		WeaponAttributes.HitLightning = 10;
		WeaponAttributes.HitLowerDefend = 40;
		Attributes.WeaponSpeed = 30;
		Attributes.WeaponDamage = -40;
		Attributes.CastSpeed = 1;
		AosElementDamages.Chaos = 100;		
		}

		public StandardOfChaosG( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
using System;
using Server;
using Server.Items;
using Server.Spells;
using Server.Spells.Seventh;
using Server.Spells.Fifth;
using System.Collections.Generic;

namespace Server.Mobiles
{
    public class AcidElementalRenowned : BaseRenowned
	{
		

        public override Type[] UniqueSAList{ get { return new Type[] {typeof( CoagulatedLegs /*Costumes*/ ) }; } }
        public override Type[] SharedSAList { get { return new Type[] { typeof(MysticsGarb), typeof(BreastplateOfTheBerserker) }; } }

		[Constructable]
        public AcidElementalRenowned () : base( AIType.AI_Mage )
		{
			Name = "Acid Elemental";
			Title = "[Renowned]";
			Body = 0x9E;
			BaseSoundID = 278;

			SetStr( 450, 600 );
			SetDex( 120, 185 );
			SetInt( 361, 435 );

			SetHits( 2000, 2400 );

			SetDamage( 9, 15 );

			SetDamageType( ResistanceType.Physical, 25 );
			SetDamageType( ResistanceType.Poison, 50 );
			SetDamageType( ResistanceType.Energy, 25 );

			SetResistance( ResistanceType.Physical, 40, 70 );
			SetResistance( ResistanceType.Fire, 30, 50 );
			SetResistance( ResistanceType.Cold, 20, 40 );
			SetResistance( ResistanceType.Poison, 10, 30 );
			SetResistance( ResistanceType.Energy, 20, 50 );

			SetSkill( SkillName.EvalInt, 80.1, 100.0 );
			SetSkill( SkillName.Magery, 80.1, 100.0 );
			SetSkill( SkillName.MagicResist, 65.2, 100.0 );
			SetSkill( SkillName.Tactics, 90.1, 100.0 );
			SetSkill( SkillName.Wrestling, 80.1, 100.0 );

			Fame = 12500;
			Karma = -12500;

			VirtualArmor = 70;

                        PackItem( new EssenceSingularity() );

			PackItem( new Nightshade( 4 ) );
			PackItem( new LesserPoisonPotion() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich );
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.MedScrolls );
		}
		
		
		
		public override bool BleedImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }


		public AcidElementalRenowned( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}
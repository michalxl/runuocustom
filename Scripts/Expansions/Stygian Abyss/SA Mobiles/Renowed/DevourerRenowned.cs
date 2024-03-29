using System;
using Server;
using Server.Items;
using Server.Spells;
using Server.Spells.Seventh;
using Server.Spells.Fifth;
using System.Collections.Generic;

namespace Server.Mobiles
{
    public class DevourerRenowned : BaseRenowned
	{
        public override Type[] UniqueSAList{ get { return new Type[] {typeof( EnchantEssence ) }; } }
        public override Type[] SharedSAList { get { return new Type[] { typeof(AnimatedLegsoftheInsaneTinker), typeof(StormCaller), typeof(PillarOfStrength) }; } }

         

		[Constructable]
		public DevourerRenowned() : base( AIType.AI_Mage )
		{
			Name = "Devourer of Souls";
			Title = "[Renowned]";
			Body = 303;
			BaseSoundID = 357;

			SetStr( 801, 950 );
			SetDex( 126, 175 );
			SetInt( 201, 250 );

			SetHits( 2000 );

			SetDamage( 22, 26 );

			SetDamageType( ResistanceType.Physical, 60 );
			SetDamageType( ResistanceType.Cold, 20 );
			SetDamageType( ResistanceType.Energy, 20 );

			SetResistance( ResistanceType.Physical, 45, 55 );
			SetResistance( ResistanceType.Fire, 25, 35 );
			SetResistance( ResistanceType.Cold, 15, 25 );
			SetResistance( ResistanceType.Poison, 60, 70 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.EvalInt, 90.1, 100.0 );
			SetSkill( SkillName.Magery, 90.1, 100.0 );
			SetSkill( SkillName.Meditation, 90.1, 100.0 );
			SetSkill( SkillName.MagicResist, 90.1, 105.0 );
			SetSkill( SkillName.Tactics, 75.1, 85.0 );
			SetSkill( SkillName.Wrestling, 80.1, 100.0 );

			Fame = 9500;
			Karma = -9500;

			VirtualArmor = 44;

                        PackItem( new EssenceAchievement() );

			PackNecroReg( 24, 45 );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 2 );
		}

		
		
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }

		public override int Meat{ get{ return 3; } }

		public DevourerRenowned( Serial serial ) : base( serial )
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
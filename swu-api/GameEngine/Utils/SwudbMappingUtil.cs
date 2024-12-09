﻿using SwuApi.GameEngine.Cards;
using System.Collections.Concurrent;

namespace SwuApi.GameEngine.Utils
{
    internal static class SwudbMappingUtil
    {
        public static ICard GetCardFromSetNumber(string setNumber)
        {
            Func<ICard> builder;
            if (SwudbBuilderMappings.TryGetValue(setNumber, out builder!))
            {
                return builder.Invoke();
            }
            throw new NotImplementedException($"Card {setNumber} has not beeen implemented.");
        }

        private static readonly IDictionary<string, Func<ICard>> SwudbBuilderMappings = new ConcurrentDictionary<string, Func<ICard>>(
            new Dictionary<string, Func<ICard>>
            {
                #region SparkOfRebellion
                { "SOR_001", () => throw new NotImplementedException() }, // Director Krennic, Aspiring to Authority
                { "SOR_002", () => throw new NotImplementedException() }, // Iden Versio, Inferno Squad Commander
                { "SOR_003", () => throw new NotImplementedException() }, // Chewbacca,Walking Carpet
                { "SOR_004", () => throw new NotImplementedException() }, // Chirrut Îmwe, One With The Force
                { "SOR_005", () => new Cards.SOR.Leaders.LukeSkywalker() }, // Luke Skywalker, Faithful Friend
                { "SOR_006", () => throw new NotImplementedException() }, // Emperor Palpatine, Galactic Ruler
                { "SOR_007", () => throw new NotImplementedException() }, // Grand Moff Tarkin, Oversector Governor
                { "SOR_008", () => throw new NotImplementedException() }, // Hera Syndulla, Spectre Two
                { "SOR_009", () => throw new NotImplementedException() }, // Leia Organa, Alliance General
                { "SOR_010", () => new Cards.SOR.Leaders.DarthVader() }, // Darth Vader, Dark Lord of the Sith
                { "SOR_011", () => throw new NotImplementedException() }, // Grand Inquisitor, Hunting the Jedi
                { "SOR_012", () => throw new NotImplementedException() }, // IG-88, Ruthless Bounty Hunter
                { "SOR_013", () => throw new NotImplementedException() }, // IG-88, Ruthless Bounty Hunter
                { "SOR_014", () => throw new NotImplementedException() }, // ⟡ Sabine Wren, Galvanized Revolutionary
                { "SOR_015", () => throw new NotImplementedException() }, // ⟡ Boba Fett, Collecting the Bounty
                { "SOR_016", () => throw new NotImplementedException() }, // ⟡ Grand Admiral Thrawn, Patient and Insightful
                { "SOR_017", () => throw new NotImplementedException() }, // ⟡ Han Solo, Audacious Smuggler
                { "SOR_018", () => throw new NotImplementedException() }, // ⟡ Jyn Erso, Resisting Oppression
                { "SOR_019", () => throw new NotImplementedException() }, // Security Complex
                { "SOR_020", () => throw new NotImplementedException() }, // Capital City
                { "SOR_021", () => throw new NotImplementedException() }, // Dagobah Swamp
                { "SOR_022", () => throw new NotImplementedException() }, // Energy Conversion Lab
                { "SOR_023", () => new Cards.SOR.Bases.CommandCenter() }, // Command Center
                { "SOR_024", () => throw new NotImplementedException() }, // Echo Base
                { "SOR_025", () => throw new NotImplementedException() }, // Tarkintown
                { "SOR_026", () => throw new NotImplementedException() }, // Catacombs of Cadera
                { "SOR_027", () => throw new NotImplementedException() }, // Kestro City
                { "SOR_028", () => throw new NotImplementedException() }, // Jedha City
                { "SOR_029", () => new Cards.SOR.Bases.AdministratorsTower() }, // Administrator's Tower
                { "SOR_030", () => throw new NotImplementedException() }, // Chopper Base
                { "SOR_031", () => throw new NotImplementedException() }, // ⟡ Inferno Four, Unforgetting
                { "SOR_032", () => throw new NotImplementedException() }, // Scout Bike Pursuer
                { "SOR_033", () => throw new NotImplementedException() }, // Death Trooper
                { "SOR_034", () => throw new NotImplementedException() }, // ⟡ Del Meeko, Providing Overwatch
                { "SOR_035", () => throw new NotImplementedException() }, // ⟡ Lieutenant Childsen, Death Star Prison Warden
                { "SOR_036", () => throw new NotImplementedException() }, // ⟡ Gideon Hask, Ruthless Loyalist
                { "SOR_037", () => throw new NotImplementedException() }, // Academy Defense Walker
                { "SOR_038", () => throw new NotImplementedException() }, // ⟡ Count Dooku, Darth Tyranus
                { "SOR_039", () => throw new NotImplementedException() }, // AT-AT Suppressor
                { "SOR_040", () => throw new NotImplementedException() }, // ⟡ Avenger, Hunting Star Destroyer
                { "SOR_041", () => throw new NotImplementedException() }, // Power of the Dark Side
                { "SOR_042", () => throw new NotImplementedException() }, // Search Your Feelings
                { "SOR_043", () => throw new NotImplementedException() }, // Superlaser Blast
                { "SOR_044", () => new Cards.SOR.Units.RestoredARC170() }, // Restored ARC-170
                { "SOR_045", () => new Cards.SOR.Units.Yoda() }, // ⟡ Yoda, Old Master
                { "SOR_046", () => new Cards.SOR.Units.ConsularSecurityForce() }, // Consular Security Force
                { "SOR_047", () => throw new NotImplementedException() }, // ⟡ Kanan Jarrus, Revealed Jedi
                { "SOR_048", () => new Cards.SOR.Units.VigilantHonorGuards() }, // Vigilant Honor Guards
                { "SOR_049", () => new Cards.SOR.Units.ObiWanKenobi() }, // ⟡ Obi-Wan Kenobi, Following Fate
                { "SOR_050", () => throw new NotImplementedException() }, // ⟡ The Ghost, Spectre Home Base
                { "SOR_051", () => throw new NotImplementedException() }, // ⟡ Luke Skywalker, Jedi Knight
                { "SOR_052", () => throw new NotImplementedException() }, // ⟡ Redemption, Medical Frigate
                { "SOR_053", () => new Cards.SOR.Upgrades.LukesLightsaber() }, // ⟡ Luke's Lightsaber
                { "SOR_054", () => throw new NotImplementedException() }, // Jedi Lightsaber
                { "SOR_055", () => throw new NotImplementedException() }, // The Force Is With Me
                { "SOR_056", () => throw new NotImplementedException() }, // ⟡ Bendu, The One In The Middle
                { "SOR_057", () => throw new NotImplementedException() }, // Protector
                { "SOR_058", () => throw new NotImplementedException() }, // Vigilance
                { "SOR_059", () => new Cards.SOR.Units._21BSurgicalDroid() }, // 2-1B Surgical Droid
                { "SOR_060", () => throw new NotImplementedException() }, // Distant Patroller
                { "SOR_061", () => throw new NotImplementedException() }, // Guardian of the Whills
                { "SOR_062", () => throw new NotImplementedException() }, // Regional Governor
                { "SOR_063", () => new Cards.SOR.Units.CloudCityWingGuard() }, // Cloud City Wing Guard
                { "SOR_064", () => throw new NotImplementedException() }, // Wilderness Fighter
                { "SOR_065", () => throw new NotImplementedException() }, // ⟡ Baze Malbus, Temple Guardian
                { "SOR_066", () => new Cards.SOR.Units.SystemPatrolCraft() }, // System Patrol Craft
                { "SOR_067", () => throw new NotImplementedException() }, // Rugged Survivors
                { "SOR_068", () => throw new NotImplementedException() }, // Cargo Juggernaut
                { "SOR_069", () => new Cards.SOR.Upgrades.Resilient() }, // Resilient
                { "SOR_070", () => throw new NotImplementedException() }, // Devotion
                { "SOR_071", () => throw new NotImplementedException() }, // Electrostaff
                { "SOR_072", () => throw new NotImplementedException() }, // Entrenched
                { "SOR_073", () => throw new NotImplementedException() }, // Moment of Peace
                { "SOR_074", () => new Cards.SOR.Events.Repair() }, // Repair
                { "SOR_075", () => throw new NotImplementedException() }, // It Binds All Things
                { "SOR_076", () => throw new NotImplementedException() }, // Make an Opening
                { "SOR_077", () => throw new NotImplementedException() }, // Takedown
                { "SOR_078", () => new Cards.SOR.Events.Vanquish() }, // Vanquish
                { "SOR_079", () => new Cards.SOR.Units.AdmiralPiett() }, // ⟡ Admiral Piett, Captain of the Executor
                { "SOR_080", () => throw new NotImplementedException() }, // ⟡ General Tagge, Concerned Commander
                { "SOR_081", () => throw new NotImplementedException() }, // Seasoned Shoretrooper
                { "SOR_082", () => throw new NotImplementedException() }, // Emperor's Royal Guard
                { "SOR_083", () => new Cards.SOR.Units.SuperlaserTechnician() }, // Superlaser Technician
                { "SOR_084", () => new Cards.SOR.Units.GrandMoffTarkin() }, // ⟡ Grand Moff Tarkin, Death Star Overseer
                { "SOR_085", () => throw new NotImplementedException() }, // ⟡ Rukh, Thrawn's Assassin
                { "SOR_086", () => new Cards.SOR.Units.GladiatorStarDestroyer() }, // Gladiator Star Destroyer
                { "SOR_087", () => throw new NotImplementedException() }, // ⟡ Darth Vader, Commanding the First Legion
                { "SOR_088", () => throw new NotImplementedException() }, // Blizzard Assault AT-AT
                { "SOR_089", () => new Cards.SOR.Units.Relentless() }, // ⟡ Relentless, Konstantine's Folly
                { "SOR_090", () => throw new NotImplementedException() }, // ⟡ Devastator, Inescapable
                { "SOR_091", () => throw new NotImplementedException() }, // The Emperor's Legion
                { "SOR_092", () => new Cards.SOR.Events.OverwhelmingBarrage() }, // Overwhelming Barrage
                { "SOR_093", () => throw new NotImplementedException() }, // Alliance Dispatcher
                { "SOR_094", () => throw new NotImplementedException() }, // ⟡ Bail Organa, Rebel Councilor
                { "SOR_095", () => throw new NotImplementedException() }, // Battlefield Marine
                { "SOR_096", () => throw new NotImplementedException() }, // ⟡ Mon Mothma, Voice of the Rebellion
                { "SOR_097", () => throw new NotImplementedException() }, // ⟡ Admiral Ackbar, Brilliant Strategist
                { "SOR_098", () => throw new NotImplementedException() }, // Echo Base Defender
                { "SOR_099", () => throw new NotImplementedException() }, // ⟡ Bright Hope, The Last Transport
                { "SOR_100", () => throw new NotImplementedException() }, // ⟡ Wedge Antilles, Star of the Rebellion
                { "SOR_101", () => throw new NotImplementedException() }, // Rogue Squadron Skirmisher
                { "SOR_102", () => throw new NotImplementedException() }, // ⟡ Home One, Alliance Flagship
                { "SOR_103", () => throw new NotImplementedException() }, // Rebel Assault
                { "SOR_104", () => throw new NotImplementedException() }, // U-Wing Reinforcement
                { "SOR_105", () => throw new NotImplementedException() }, // ⟡ General Krell, Heartless Tactician
                { "SOR_106", () => throw new NotImplementedException() }, // Attack Pattern Delta
                { "SOR_107", () => throw new NotImplementedException() }, // Command
                { "SOR_108", () => throw new NotImplementedException() }, // Vanguard Infantry
                { "SOR_109", () => throw new NotImplementedException() }, // ⟡ Colonel Yularen, ISB Director
                { "SOR_110", () => throw new NotImplementedException() }, // Frontline Shuttle
                { "SOR_111", () => throw new NotImplementedException() }, // Patrolling V-Wing
                { "SOR_112", () => throw new NotImplementedException() }, // Consortium StarViper
                { "SOR_113", () => throw new NotImplementedException() }, // Homestead Militia
                { "SOR_114", () => throw new NotImplementedException() }, // Escort Skiff
                { "SOR_115", () => throw new NotImplementedException() }, // ⟡ Agent Kallus, Seeking the Rebels
                { "SOR_116", () => throw new NotImplementedException() }, // Steadfast Battalion
                { "SOR_117", () => throw new NotImplementedException() }, // Mercenary Company
                { "SOR_118", () => throw new NotImplementedException() }, // ⟡ 97th Legion, Keeping the Peace on Sullust
                { "SOR_119", () => throw new NotImplementedException() }, // Reinforcement Walker
                { "SOR_120", () => throw new NotImplementedException() }, // Academy Training
                { "SOR_121", () => throw new NotImplementedException() }, // Hardpoint Heavy Blaster
                { "SOR_122", () => throw new NotImplementedException() }, // Traitorous
                { "SOR_123", () => new Cards.SOR.Events.Recruit() }, // Recruit
                { "SOR_124", () => throw new NotImplementedException() }, // Tactical Advantage
                { "SOR_125", () => throw new NotImplementedException() }, // Prepare for Takeoff
                { "SOR_126", () => new Cards.SOR.Events.Resupply() }, // Resupply
                { "SOR_127", () => throw new NotImplementedException() }, // Strike True
                { "SOR_128", () => new Cards.SOR.Units.DeathStarStormtrooper() },
                { "SOR_129", () => throw new NotImplementedException() }, // ⟡ Admiral Ozzel, Overconfident
                { "SOR_130", () => new Cards.SOR.Units.FirstLegionSnowtrooper() }, // First Legion Snowtrooper
                { "SOR_131", () => throw new NotImplementedException() }, // ⟡ Fifth Brother, Fear Hunter
                { "SOR_132", () => new Cards.SOR.Units.ImperialInterceptor() }, // Imperial Interceptor
                { "SOR_133", () => throw new NotImplementedException() }, // ⟡ Seventh Sister, Implacable Inquisitor
                { "SOR_134", () => throw new NotImplementedException() }, // Ruthless Raider
                { "SOR_135", () => new Cards.SOR.Units.EmperorPalpatine() }, // ⟡ Emperor Palpatine, Master of the Dark Side
                { "SOR_136", () => new Cards.SOR.Upgrades.VadersLightsaber() }, // ⟡ Vader's Lightsaber
                { "SOR_137", () => throw new NotImplementedException() }, // Fallen Lightsaber
                { "SOR_138", () => throw new NotImplementedException() }, // Force Lightning
                { "SOR_139", () => new Cards.SOR.Events.ForceChoke() }, // Force Choke
                { "SOR_140", () => throw new NotImplementedException() }, // SpecForce Soldier
                { "SOR_141", () => throw new NotImplementedException() }, // Green Squadron A-Wing
                { "SOR_142", () => throw new NotImplementedException() }, // ⟡ Sabine Wren, Explosives Artist
                { "SOR_143", () => throw new NotImplementedException() }, // Fighters For Freedom
                { "SOR_144", () => throw new NotImplementedException() }, // ⟡ Red Three, Unstoppable
                { "SOR_145", () => throw new NotImplementedException() }, // ⟡ K-2SO, Cassian's Counterpart
                { "SOR_146", () => throw new NotImplementedException() }, // ⟡ Zeb Orrelios, Headstrong Warrior
                { "SOR_147", () => throw new NotImplementedException() }, // ⟡ Black One, Scourge of Starkiller Base
                { "SOR_148", () => throw new NotImplementedException() }, // Guerilla Attack Pod
                { "SOR_149", () => throw new NotImplementedException() }, // ⟡ Mace Windu, Party Crasher
                { "SOR_150", () => throw new NotImplementedException() }, // Heroic Sacrifice
                { "SOR_151", () => throw new NotImplementedException() }, // Karabast
                { "SOR_152", () => throw new NotImplementedException() }, // For A Cause I Believe In
                { "SOR_153", () => throw new NotImplementedException() }, // ⟡ Saw Gerrera, Extremist
                { "SOR_154", () => throw new NotImplementedException() }, // Rallying Cry
                { "SOR_155", () => throw new NotImplementedException() }, // Aggression
                { "SOR_156", () => throw new NotImplementedException() }, // ⟡ Benthic "Two Tubes", Partisan Lieutenant
                { "SOR_157", () => throw new NotImplementedException() }, // Cantina Braggart
                { "SOR_158", () => throw new NotImplementedException() }, // Jedha Agitator
                { "SOR_159", () => throw new NotImplementedException() }, // Partisan Insurgent
                { "SOR_160", () => throw new NotImplementedException() }, // ⟡ Wolffe, Suspicious Veteran
                { "SOR_161", () => throw new NotImplementedException() }, // Ardent Sympathizer
                { "SOR_162", () => throw new NotImplementedException() }, // Disabling Fang Fighter
                { "SOR_163", () => throw new NotImplementedException() }, // Star Wing Scout
                { "SOR_164", () => throw new NotImplementedException() }, // Wampa
                { "SOR_165", () => throw new NotImplementedException() }, // Occupier Siege Tank
                { "SOR_166", () => throw new NotImplementedException() }, // Infiltrator's Skill
                { "SOR_167", () => throw new NotImplementedException() }, // Force Throw
                { "SOR_168", () => throw new NotImplementedException() }, // Precision Fire
                { "SOR_169", () => throw new NotImplementedException() }, // Keep Fighting
                { "SOR_170", () => throw new NotImplementedException() }, // Power Failure
                { "SOR_171", () => throw new NotImplementedException() }, // Mission Briefing
                { "SOR_172", () => new Cards.SOR.Events.OpenFire() }, // Open Fire
                { "SOR_173", () => throw new NotImplementedException() }, // Bombing Run
                { "SOR_174", () => throw new NotImplementedException() }, // Smoke and Cinders
                { "SOR_175", () => throw new NotImplementedException() }, // Forced Surrender
                { "SOR_176", () => throw new NotImplementedException() }, // ISB Agent
                { "SOR_177", () => throw new NotImplementedException() }, // ⟡ Bib Fortuna, Jabba's Majordomo
                { "SOR_178", () => throw new NotImplementedException() }, // Cartel Spacer
                { "SOR_179", () => throw new NotImplementedException() }, // ⟡ Boba Fett, Disintegrator
                { "SOR_180", () => throw new NotImplementedException() }, // Seventh Fleet Defender
                { "SOR_181", () => throw new NotImplementedException() }, // ⟡ Jabba the Hutt, Cunning Daimyo
                { "SOR_182", () => throw new NotImplementedException() }, // ⟡ Bossk, Deadly Stalker
                { "SOR_183", () => throw new NotImplementedException() }, // Bounty Hunter Crew
                { "SOR_184", () => throw new NotImplementedException() }, // ⟡ Fett's Firespray, Pursuing the Bounty
                { "SOR_185", () => throw new NotImplementedException() }, // ⟡ Chimaera, Flagship of the Seventh Fleet
                { "SOR_186", () => throw new NotImplementedException() }, // No Good to Me Dead
                { "SOR_187", () => throw new NotImplementedException() }, // I Had No Choice
                { "SOR_188", () => throw new NotImplementedException() }, // ⟡ Chopper, Metal Menace
                { "SOR_189", () => new Cards.SOR.Units.LeiaOrgana() }, // ⟡ Leia Organa, Defiant Princess
                { "SOR_190", () => throw new NotImplementedException() }, // Lothal Insurgent
                { "SOR_191", () => throw new NotImplementedException() }, // Vanguard Ace
                { "SOR_192", () => throw new NotImplementedException() }, // ⟡ Ezra Bridger, Resourceful Troublemaker
                { "SOR_193", () => throw new NotImplementedException() }, // ⟡ Millennium Falcon, Piece of Junk
                { "SOR_194", () => new Cards.SOR.Units.RogueOperative() }, // Rogue Operative
                { "SOR_195", () => new Cards.SOR.Units.AuzituckLiberatorGunship() }, // Auzituck Liberator Gunship
                { "SOR_196", () => new Cards.SOR.Units.Chewbacca() }, // ⟡ Chewbacca, Loyal Companion
                { "SOR_197", () => throw new NotImplementedException() }, // ⟡ Lando Calrissian, Responsible Businessman
                { "SOR_198", () => new Cards.SOR.Units.HanSolo() }, // ⟡ Han Solo, Reluctant Hero
                { "SOR_199", () => throw new NotImplementedException() }, // Bamboozle
                { "SOR_200", () => throw new NotImplementedException() }, // Spark of Rebellion
                { "SOR_201", () => throw new NotImplementedException() }, // ⟡ Bodhi Rook, Imperial Defector
                { "SOR_202", () => throw new NotImplementedException() }, // Cantina Bouncer
                { "SOR_203", () => throw new NotImplementedException() }, // Cunning
                { "SOR_204", () => throw new NotImplementedException() }, // ⟡ Greedo, Slow on the Draw
                { "SOR_205", () => throw new NotImplementedException() }, // Jawa Scavenger
                { "SOR_206", () => throw new NotImplementedException() }, // Mining Guild TIE Fighter
                { "SOR_207", () => throw new NotImplementedException() }, // Crafty Smuggler
                { "SOR_208", () => throw new NotImplementedException() }, // Outer Rim Headhunter
                { "SOR_209", () => throw new NotImplementedException() }, // Pirated Starfighter
                { "SOR_210", () => throw new NotImplementedException() }, // Swoop Racer
                { "SOR_211", () => throw new NotImplementedException() }, // Gamorrean Guards
                { "SOR_212", () => throw new NotImplementedException() }, // Strafing Gunship
                { "SOR_213", () => throw new NotImplementedException() }, // Syndicate Lackeys
                { "SOR_214", () => throw new NotImplementedException() }, // Smuggling Compartment
                { "SOR_215", () => throw new NotImplementedException() }, // Snapshot Reflexes
                { "SOR_216", () => throw new NotImplementedException() }, // Disarm
                { "SOR_217", () => new Cards.SOR.Events.ShootFirst() }, // Shoot First
                { "SOR_218", () => new Cards.SOR.Events.AsteroidSanctuary() }, // Asteroid Sanctuary
                { "SOR_219", () => throw new NotImplementedException() }, // Sneak Attack
                { "SOR_220", () => new Cards.SOR.Events.SurpriseStrike() }, // Surprise Strike
                { "SOR_221", () => throw new NotImplementedException() }, // Outmaneuver
                { "SOR_222", () => new Cards.SOR.Events.Waylay() }, // Waylay
                { "SOR_223", () => new Cards.SOR.Events.DontGetCocky() }, // Don't Get Cocky
                { "SOR_224", () => throw new NotImplementedException() }, // Change of Heart
                { "SOR_225", () => new Cards.SOR.Units.TIElnFighter() }, // TIE/ln Fighter
                { "SOR_226", () => new Cards.SOR.Units.AdmiralMotti() }, // ⟡ Admiral Motti, Brazen and Scornful
                { "SOR_227", () => new Cards.SOR.Units.SnowtrooperLieutenant() }, // Snowtrooper Lieutenant
                { "SOR_228", () => new Cards.SOR.Units.ViperProbeDroid() }, // Viper Probe Droid
                { "SOR_229", () => new Cards.SOR.Units.CellBlockGuard() }, // Cell Block Guard
                { "SOR_230", () => new Cards.SOR.Units.GeneralVeers() }, // ⟡ General Veers, Blizzard Force Commander
                { "SOR_231", () => new Cards.SOR.Units.TIEAdvanced() }, // TIE Advanced
                { "SOR_232", () => new Cards.SOR.Units.ATST() }, // AT-ST
                { "SOR_233", () => throw new NotImplementedException() }, // I Am Your Father
                { "SOR_234", () => new Cards.SOR.Events.MaximumFirepower() }, // Maximum Firepower
                { "SOR_235", () => throw new NotImplementedException() }, // Galactic Ambition
                { "SOR_236", () => new Cards.SOR.Units.R2D2() }, // ⟡ R2-D2, Ignoring Protocol
                { "SOR_237", () => new Cards.SOR.Units.AllianceXWing() }, // Alliance X-Wing
                { "SOR_238", () => new Cards.SOR.Units.C3PO() }, // ⟡ C-3PO, Protocol Droid
                { "SOR_239", () => new Cards.SOR.Units.RebelPathfinder() }, // Rebel Pathfinder
                { "SOR_240", () => new Cards.SOR.Units.FleetLieutenant() }, // Fleet Lieutenant
                { "SOR_241", () => new Cards.SOR.Units.WingLeader() }, // Wing Leader
                { "SOR_242", () => new Cards.SOR.Units.GeneralDodonna() }, // ⟡ General Dodonna, Massassi Group Commander
                { "SOR_243", () => throw new NotImplementedException() }, // Regional Sympathizers
                { "SOR_244", () => new Cards.SOR.Units.Snowspeeder() }, // Snowspeeder
                { "SOR_245", () => throw new NotImplementedException() }, // Medal Ceremony
                { "SOR_246", () => throw new NotImplementedException() }, // You're My Only Hope
                { "SOR_247", () => throw new NotImplementedException() }, // Underworld Thug
                { "SOR_248", () => throw new NotImplementedException() }, // Volunteer Soldier
                { "SOR_249", () => throw new NotImplementedException() }, // Frontier AT-RT
                { "SOR_250", () => throw new NotImplementedException() }, // Corellian Freighter
                { "SOR_251", () => throw new NotImplementedException() }, // Confiscate
                { "SOR_252", () => throw new NotImplementedException() }, // Restock
                #endregion
            });
    }
}
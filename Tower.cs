using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Companion
{
    class Tower
    {
        public string name;

        public string[] items;
        //public int[] ducats;
        public double[] chance;

        public Tower() { }
    }

    class Rotation
    {
        public string name;

        public string[] rotA, rotB, rotC;
        public double[] rotAchance, rotBchance, rotCchance;

        public Rotation() { }
    }

    class T1C : Tower
    {
        public T1C()
        {
            this.name = "Tower I Capture";

            this.items = new string[] { "Odonate Prime", "Paris Prime Grip", "Lex Prime Receiver", "Forma", "Tower I Defense", "Paris Prime String", "Tower II Capture" };
            this.chance = new double[] { 5.64, 5.64, 5.64, 5.64, 25.81, 25.81, 25.81 };
        }
    }

    class T2C : Tower
    {
        public T2C()
        {
            this.name = "Tower II Capture";

            this.items = new string[] { "Orthos Prime Handle", "Paris Prime String", "Forma Blueprint", "Orthos Prime Blade", "Volt Prime Blueprint", "Nyx Prime Blueprint", "Loki Prime Blueprint" };
            this.chance = new double[] { 14.29, 14.29, 14.29, 14.29, 14.29, 14.29, 14.29 };
        }
    }

    class T3C : Tower
    {
        public T3C()
        {
            this.name = "Tower III Capture";

            this.items = new string[] { "Spira Prime Pouch", "Forma Blueprint", "Nikana Prime Hilt", "Dual Kamas Prime Blade", "Akbronco Prime Link", "Burston Prime Barrel", "Lex Prime Barrel" };
            this.chance = new double[] { 5.64, 25.81, 5.64, 5.64, 5.64, 25.81, 25.81 };
        }
    }

    class T4C: Tower
    {
        public T4C()
        {
            this.name = "Tower IV Capture";

            this.items = new string[] { "Nyx Prime Systems Blueprint", "Forma Blueprint", "Bronco Prime Receiver", "Volt Prime Blueprint", "Akbronco Prime Link", "Rare Fusioun Core x5" };
            this.chance = new double[] { 19.36, 19.36, 19.36, 11.28, 19.36, 11.28 };
        }
    }

    class T1D : Rotation
    {
        public T1D()
        {
            this.name = "Tower I Defense";

            this.rotA = new string[] { "Rare Fusion Core", "Tower I Capture", "Tower III Capture", "Tower II Mob. Defense" };
            this.rotB = new string[] { "Rare Fusion Core", "Tower I Mob. Defense", "Tower II Defense", "Orokin Cell", "Tower II Mob. Defense", "Tower II Capture" };
            this.rotC = new string[] { "Vasto Prime Receiver", "Carrier Prime Systems", "Forma Blueprint", "Hikou Prime Stars", "Bo Prime Ornament" };

            this.rotAchance = new double[] { 38.72, 38.72, 11.28, 11.28 };
            this.rotBchance = new double[] { 15.49, 15.49, 15.49, 22.56, 15.49, 15.49 };
            this.rotCchance = new double[] { 11.28, 25.81, 11.28, 25.81, 25.81 };
        }
    }

    class T2D : Rotation
    {
        public T2D()
        {
            this.name = "Tower II Defense";

            this.rotA = new string[] { "Rare Fusion Core x2", "Uncom. Fusion Core x2", "Soma Prime Blueprint", "Orokin Cell", "Orthos Prime Blade" };
            this.rotB = new string[] { "Rare Fusion Core x2", "Uncom. Fusion Core x2", "Burstone Prime Stock", "Paris Prime Blueprint" };
            this.rotC = new string[] { "Fang Prime Handle", "Braton Prime Stock", "Lex Prime Receiver", "Paris Prime Upper Limb", "Fang Prime Blueprint" };

            this.rotAchance = new double[] { 20, 20, 20, 20, 20 };
            this.rotBchance = new double[] { 25, 25, 25, 25 };
            this.rotCchance = new double[] { 20, 20, 20, 20, 20 };
        }
    }

    class T3D : Rotation
    {
        public T3D()
        {
            this.name = "Tower III Defense";

            this.rotA = new string[] { "Rare Fusion Core x3","Trinity Prime Chasis BP","Orokin Cell","Uncom. Fusion Core x3" };
            this.rotB = new string[] { "Rare Fusion Core x3", "Uncom. Fusion Core x3", "Lex Prime Blueprint", "Paris Prime String", "Burston Prime Blueprint" };
            this.rotC = new string[] { "Braton Prime Barrel", "Braton Prime Receiver", "Forma Blueprint", "Ash Prime Blueprint", "Braton Prime Stock", "Bo Prime Blueprint", "Wyrm Prime Cerebrum" };

            this.rotAchance = new double[] { 25, 25, 25, 25 };
            this.rotBchance = new double[] { 20, 20, 20, 20, 20 };
            this.rotCchance = new double[] { 7.52, 7.52, 19.36, 7.52, 19.36, 19.36, 19.36 };
        }
    }

    class T4D : Rotation
    {
        public T4D()
        {
            this.name = "Tower IV Defense";

            this.rotA = new string[] { "Rare Fusion Core x5","Forma Blueprint", "Lex Prime Blueprint", "Orthos Prime Handle", "Wyrm Prime Systems" };
            this.rotB = new string[] { "Braton Prime Barrel", "Braton Prime Receiver", "Carrier Prime Systems", "Rare Fusion Core x5" };
            this.rotC = new string[] { "Loki Prime Systems Blueprint", "Nyx Prime Blueprint", "Trinity Prime Blueprint", "Odonata Prime Blueprint", "Carrier Prime Carapace", "Burston Prime Receiver", "Hikou Prime Pouch", "Rare Fusion Core x5" };

            this.rotAchance = new double[] { 20, 20, 20, 20, 20 };
            this.rotBchance = new double[] { 25, 25, 25, 25 };
            this.rotCchance = new double[] { 5.64, 5.64, 5.64, 19.36, 19.36, 19.36, 19.36, 5.64 };
        }
    }

    class T1E : Tower
    {
        public T1E()
        {
            this.name = "Tower I Exterminate";

            this.items = new string[] { "Scindo Prime Blueprint", "Wyrm Prime Cerebrum", "Forma Blueprint", "Tower I Mobile Defense", "Tower II Exterminate", "Burston Prime Stock" };

            this.chance = new double[] { 7.52, 7.52, 7.52, 25.81, 25.81, 25.81 };
        }
    }

    class T2E : Tower
    {
        public T2E()
        {
            this.name = "Tower II Exterminate";

            this.items = new string[] { "Carrier Prime Cerebrum", "Volt Prime Helmet Blueprint", "Nova Prime Blueprint", "Forma Blueprint", "Orthos Prime Blueprint", "Saryn Prime Systems Blueprint", "Wyrm Prime Blueprint" };
            this.chance = new double[] { 7.52, 19.36, 19.36, 19.36, 7.52, 19.36, 7.52 };
        }
    }

    class T3E : Tower
    {
        public T3E()
        {
            this.name = "Tower III Exterminate";

            this.items = new string[] { "Nyx Prime Chasis Blueprint", "Soma Prime Stock", "Vasto Prime Receiver", "Nikana Prime Blueprint", "Saryn Prime Blueprint", "Nyx Prime Systems Blueprint" };
            this.chance = new double[] { 5.64, 5.64, 38.72, 5.64, 5.64, 38.72 };
        }
    }

    class T4E : Tower
    {
        public T4E()
        {
            this.name = "Tower IV Exterminate";

            this.items = new string[] { "Kavasa Prime Collar Buckle", "Forma Blueprint", "Odonata P Harness Blueprint", "Hikou Prime Pouch", "Saryn Prime Blueprint", "Vectis Prime Receiver", "Rare Fusion Core x5" };
            this.chance = new double[] { 5.64, 5.64, 25.81, 25.81, 5.64, 5.64, 25.81 };
        }
    }

    class Int : Rotation
    {
        public Int()
        {
            this.name = "Tower IV Interception";

            this.rotA = new string[] { "Rare Fusion Core x5", "Carrier Prime Blueprint", "Akbronco Prime Blueprint", "Loki Prime Blueprint" };
            this.rotB = new string[] { "Vectis Prime Barrel", "Rare Fusion Core x5", "Hikou Prime Blueprint", "Forma Blueprint" };
            this.rotC = new string[] { "Wyrm Prime Systems", "Soma Prime Barrel", "Fang Prime Handle", "Lex Prime Receiver", "Paris Prime Grip", "Bo Prime Handle", "Forma Blueprint" };

            this.rotAchance = new double[] { 25, 25, 25, 25 };
            this.rotBchance = new double[] { 25, 25, 25, 25 };
            this.rotCchance = new double[] { 14.29, 14.29, 14.29, 14.29, 14.29, 14.29, 14.29 };
        }
    }

    class T1MD : Tower
    {
        public T1MD()
        {
            this.name = "Tower I Mobile Defense";

            this.items = new string[] { "Saryn Prime Helmet Blueprint", "Vectis Prime Blueprint", "Braton Prime Barrel", "Forma Blueprint", "Tower I Capture", "Tower II Mobile Defense" };
            this.chance = new double[] { 7.52, 7.52, 25.81, 7.52, 25.81, 25.81 };
        }
    }

    class T2MD : Tower
    {
        public T2MD()
        {
            this.name = "Tower II Mobile Defense";

            this.items = new string[] { "Burston Prime Blueprint", "Nyx Prime Helmet Blueprint", "Vasto Prime Blueprint", "Braton Prime Blueprint", "Vasto Prime Barrel", "Bo Prime Blueprint" };
            this.chance = new double[] { 19.36, 11.28, 11.28, 19.36, 19.36, 19.36 };
        }
    }

    class T3MD : Tower
    {
        public T3MD()
        {
            this.name = "Tower III Mobile Defense";

            this.items = new string[] { "Vectis Prime Stock", "Trinity Prime Systems Blueprint", "Scindo Prime Blade", "Forma Blueprint", "Spria Prime Blade", "Soma Prime Barrel", "Burston Prime Receiver" };
            this.chance = new double[] { 5.64, 5.64, 5.64, 25.81, 5.64, 25.81, 25.81 };
        }
    }

    class T4MD : Tower
    {
        public T4MD()
        {
            this.name = "Tower IV Mobile Defense";

            this.items = new string[] { "Bo Prime Handle", "Kavasa Prime Collar Blueprint", "Vasto Prime Receiver", "Forma Blueprint", "Spira Prime Blueprint", "Rare Fusion Core x5" };
            this.chance = new double[] { 16.67, 16.67, 16.67, 16.67, 16.67, 16.67 };
        }
    }
    
    class T1Sab : Rotation
    {
        public T1Sab()
        {
            this.name = "Tower I Sabotage";

            this.rotA = new string[] { "Scindo Prime Handle", "Odonata P Harness BP", "Hikou Prime Stars", "Nova Prime Blueprint", "Odonata P Systems BP", "Vasto Prime Barrel" };
            this.rotB = new string[] { "Uncom. Fusion Core", "Morphics", "Argon Crystal", "Orokin Cell", "Neurodes", "Neural Sensors" };
            this.rotC = new string[] { "2000 Credits Cache", "2500 Credits Cache", "3000 Credits Cache", "Rare Fusion Core", "Uncommon Fusion Core", "Common Fusion Core" };

            this.rotAchance = new double[] { 11.28, 11.28, 19.36, 19.36, 19.36, 19.36 };
            this.rotBchance = new double[] { 77.44, 4.51, 4.51, 4.51, 4.51, 4.51 };
            this.rotCchance = new double[] { 19.36, 19.36, 19.36, 11.28, 11.28, 19.36 };
        }
    }

    class T2Sab : Rotation
    {
        public T2Sab()
        {
            this.name = "Tower II Sabotage";

            this.rotA = new string[] { "Nyx Prime Helmet BP", "Loki Prime Blueprint", "Hikou Prime Blueprint", "Bronco Prime Blueprint", "Wyrm Prime Carapace", "Hikou Prime Pouch", "Trinity Prime Helmet BP" };
            this.rotB = new string[] { "Uncom. Fusion Core", "Orokin Cell", "Morphics", "Neural Sensors", "Neurodes", "Argon Crystal" };
            this.rotC = new string[] { "2000 Credits Cache", "2500 Credits Cache", "3000 Credits Cache", "Common Fusion Core", "Uncommon Fusion Core", "Rare Fusion Core" };

            this.rotAchance = new double[] { 5.64, 5.64, 25.81, 25.81, 5.64, 25.81, 5.64 };
            this.rotBchance = new double[] { 77.44, 4.51, 4.51, 4.51, 4.51, 4.51, };
            this.rotCchance = new double[] { 19.36, 19.36, 19.36, 19.36, 11.28, 11.28 };
        }
    }

    class T3Sab : Rotation
    {
        public T3Sab()
        {
            this.name = "Tower III Sabotage";

            this.rotA = new string[] { "Loki Prime Helmet BP", "Forma Blueprint", "Scindo Prime Blade", "Loki Prime Systems BP", "Bronco Prime Barrel", "Soma Prime Barrel", "Wyrm Prime Carapace", "Forma" };
            this.rotB = new string[] { "Uncom. Fusion Core", "Orokin Cell", "Morphics", "Neural Sensors", "Neurodes", "Argon Crystal" };
            this.rotC = new string[] { "2000 Credits Cache", "2500 Credits Cache", "3000 Credits Cache", "Common Fusion Core", "Uncommon Fusion Core", "Rare Fusion Core" };

            this.rotAchance = new double[] { 25.29, 25.29, 5.53, 5.53, 5.53, 25.29, 5.53, 2.01 };
            this.rotBchance = new double[] { 77.44, 4.51, 4.51, 4.51, 4.51, 4.51, };
            this.rotCchance = new double[] { 19.36, 19.36, 19.36, 19.36, 11.28, 11.28 };
        }
    }

    class T4Sab : Rotation
    {
        public T4Sab()
        {
            this.name = "Tower IV Sabotage";

            this.rotA = new string[] { "Loki Prime Helmet BP", "Nyx Prime Systems BP", "Carrier Prime Systems", "Forma Blueprint", "Loki Prime Chasis BP", "Kavasa P Collar Band", "Ash Prime Helmet BP", "Nova Prime Helmet BP" };
            this.rotB = new string[] { "Uncom. Fusion Core", "Orokin Cell", "Morphics", "Neural Sensors", "Neurodes", "Argon Crystal" };
            this.rotC = new string[] { "2000 Credits Cache", "2500 Credits Cache", "3000 Credits Cache", "Common Fusion Core", "Uncommon Fusion Core", "Rare Fusion Core" };

            this.rotAchance = new double[] { 7.52, 15.49, 15.49, 7.52, 15.49, 7.52, 15.49, 15.49 };
            this.rotBchance = new double[] { 77.44, 4.51, 4.51, 4.51, 4.51, 4.51, };
            this.rotCchance = new double[] { 19.36, 19.36, 19.36, 19.36, 11.28, 11.28 };
        }
    }

    class T1S : Rotation
    {
        public T1S()
        {
            this.name = "Tower I Survival";

            this.rotA = new string[] { "Rare Fusion Core", "Bo Prime Ornament", "Tower I Defense", "Tower III Exterminate", "Tower I Capture", "Odonata P Syst. BP" };
            this.rotB = new string[] { "Rare Fusion Core", "Tower II Survival", "Uncom. Fusion Core", "Tower II Mob. Defense", "Tower II Capture" };
            this.rotC = new string[] { "Scindo Prime Handle", "Paris Prime Upper Limb", "Volt Prime Systems Blueprint", "Paris Prime Lower Limb", "Burston Prime Stock", "Nova Prime Helmet Blueprint" };

            this.rotAchance = new double[] { 16.67, 16.67, 16.67, 16.67, 16.67, 16.67 };
            this.rotBchance = new double[] { 7.52, 7.52, 7.52, 38.72, 38.72 };
            this.rotCchance = new double[] { 7.52, 7.52, 7.52, 25.81, 25.81, 25.81 };
        }
    }

    class T2S : Rotation
    {
        public T2S()
        {
            this.name = "Tower II Survival";

            this.rotA = new string[] { "Rare Fusion Core x2", "Orokin Cell", "Akbronco Prime Blueprint", "Paris Prime Lower Limb", "Forma Blueprint" };
            this.rotB = new string[] { "Soma Prime Blueprint", "Fang Prime Blade", "Rare Fusion Core x2", "Uncom. Fusion Core x2", "Hikou Prime Blueprint" };
            this.rotC = new string[] { "Burston Prime Receiver", "Soma Prime Receiver", "Paris Prime Blueprint", "Ash Prime Chasis Blueprint", "Nikana Prime Blade", "Bronco Prime Blueprint", "Trinity Prime Chasis Blueprint" };

            this.rotAchance = new double[] { 20, 20, 20, 20, 20 };
            this.rotBchance = new double[] { 20, 20, 20, 20, 20 };
            this.rotCchance = new double[] { 7.52, 7.52, 19.36, 19.36, 7.52, 19.36, 19.36 };
        }
    }

    class T3S : Rotation
    {
        public T3S()
        {
            this.name = "Tower III Survival";

            this.rotA = new string[] {"Rare Fusion Core x3", "Fang Prime Blueprint", "Fang Prime Blade", "Uncom. Fusion Core x3", "Orokin Cell x3" };
            this.rotB = new string[] { "Uncom. Fsion Core x3", "Rare Fusion Core x3", "Vectis Prime Barrel", "Lex Prime Barrel", "Volt Prime Helmet BP" };
            this.rotC = new string[] { "Bo Prime Blueprint", "Carrier Prime Blueprint", "Volt Prime Chasis Blueprint", "Ash Prime Systems Blueprint", "Saryn Prime Chasis Blueprint", "Dual Kamas Prime Blueprint", "Nova Prime Chasis Blueprint", "Forma"};

            this.rotAchance = new double[] { 20, 20, 20, 20, 20 };
            this.rotBchance = new double[] { 20, 20, 20, 20, 20 };
            this.rotCchance = new double[] { 25.29, 25.29, 5.53, 5.53, 5.53, 25.29, 5.53, 2.01 };
        }
    }

    class T4S : Rotation
    {
        public T4S()
        {
            this.name = "Tower IV Survival";

            this.rotA = new string[] { "Uncom. Fusion Core x5", "Ash Prime Chasis BP", "Bo Prime Ornament", "Orokin Cell x3" };
            this.rotB = new string[] { "Orthos Prime Blueprint", "Rare Fusion Core x5", "Bronco Prime Receiver", "Lex Prime Barrel" };
            this.rotC = new string[] { "Loki Prime Helmet Blueprint", "Braton Prime Blueprint", "Forma Blueprint", "Odonata Prime Wings Blueprint", "Vasto Prime Blueprint", "Loki Prime Chasis Blueprint","Rare Fusion Core x5" };

            this.rotAchance = new double[] { 25, 25, 25, 25 };
            this.rotBchance = new double[] { 25, 25, 25, 25 };
            this.rotCchance = new double[] { 14.19, 14.19, 14.19, 14.19, 14.19, 14.19, 14.19 };
        }
    }

    class ODD : Rotation
    {
        public ODD()
        {
            this.name = "Derelict Defense";

            this.rotA = new string[] { "Rare Fusion Core x3", "Uncom.Fusion Core x3", "Tower I Capture","Tower I Defense","Tower I Survival","Tower I Mob. Defense","Tower I Extermiante"};
            this.rotB = new string[] { "Rare Fusion Core x3", "Uncom. Fusion Core x3", "Mutalist Alad V Nav Coord" };
            this.rotC = new string[] { "Trinity Prime Blueprint", "Dual Kamas Prime Handle", "Soma Prime Stock", "Tower II Mobile Defense", "Tower II Capture", "Tower II Extermiante", "Forma Blueprint", "Tower II Defense", "Tower II Survival" };

            this.rotAchance = new double[] { 14.29, 14.29, 14.29, 14.29, 14.29, 14.29, 14.29 };
            this.rotBchance = new double[] { 37.5, 37.5, 25 };
            this.rotCchance = new double[] { 12.91, 7.52, 12.91, 7.52, 12.91, 12.91, 7.52, 12.91, 12.91 };
        }
    }

    class ODS : Rotation
    {
        public ODS()
        {
            this.name = "Derelict Survival";

            this.rotA = new string[] { "Rare Fusion Core x3", "Uncom. Fusion Core x3", "Tower I Exterminate", "Tower I Mob. Defense" };
            this.rotB = new string[] { "Tower I Capture", "Tower I Defense", "Tower I Exterminate", "Tower I Mob. Defense", "Mutalist Alad V Nav Coord" };
            this.rotC = new string[] { "Burston Prime Barrel", "Tower II Capture", "Tower II Mobile Defense", "Tower II Extermiante", "Nova Prime Systems Blueprint", "Forma Blueprint" };

            this.rotAchance = new double[] { 25, 25, 25, 25 };
            this.rotBchance = new double[] { 20, 20, 20, 20, 20 };
            this.rotCchance = new double[] { 19.36, 19.36, 19.36, 19.36, 11.28, 11.28 };
        }
    }
}

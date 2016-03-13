using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Companion
{
    class Item
    {
        public string name;

        public string[] pieces;

        public string[][] locations;
        public double[][] chances;

        public Item() { }
    }

    class akbronco : Item
    {
        public akbronco()
        {
            this.name = "Akbronco Prime";

            this.pieces = new string[] { "Blueprint", "Link", "Bronco Prime x2" };
            this.locations = new string[][] { new string[] { "Tower II Survival A", "Tower IV Interception A" }, new string[] { "Tower III Capture", "Tower IV Capture" }, new string[] { } };
            this.chances = new double[][] { new double[] { 20, 25 }, new double[] { 5.64, 19.36 }, new double[] { } };
        }
    }

    class ash : Item
    {
        public ash()
        {
            this.name = "Ash Prime";

            this.pieces = new string[] { "Blueprint", "Chasis Blueprint", "Helmet Blueprint", "Systems Blueprint" };
            this.locations = new string[][] { new string[] { "Tower III Defense C" }, new string[] { "Tower II Survival C", "Tower IV Survival A" }, new string[] { "Tower IV Sabotage" }, new string[] { "Tower III Survival C" } };
            this.chances = new double[][] { new double[] { 7.52 }, new double[] { 19.36, 25 }, new double[] { 15.49 }, new double[] { 5.53 } };
        }       
    }

    class bo : Item
    {
        public bo()
        {
            this.name = "Bo Prime";

            this.pieces = new string[] { "Blueprint", "Handle", "Ornament x2" };
            this.locations = new string[][] { new string[] { "Tower II Mobile Defense", "Tower III Defense C", "Tower III Survival C" }, new string[] { "Tower IV Interception C", "Tower IV Mobile Defense" }, new string[] { "Tower I Defense C", "Tower I Survival A", "Tower IV Survival A" } };
            this.chances = new double[][] { new double[] { 19.36, 19.36, 25.29 }, new double[] { 14.29, 16.67 }, new double[] { 25.81, 16.67, 25 } };
        }
    }

    class braton : Item
    {
        public braton()
        {
            this.name = "Braton Prime";

            this.pieces = new string[] { "Barrel", "Blueprint", "Receiver", "Stock" };
            this.locations = new string[][] { new string[] { "Tower I Mobile Defense", "Tower III Defense C", "Tower IV Defense B" }, new string[] { "Tower II Mobile Defense", "Tower IV Survival C" }, new string[] { "Tower III Defense C", "Tower IV Defense B" }, new string[] { "Tower II Defense C", "Tower III Defense C" } };
            this.chances = new double[][] { new double[] { 25.81, 7.52, 25 }, new double[] { 19.36, 14.19 }, new double[] { 7.52, 25 }, new double[] { 20, 19.36 } };
        }
    }

    class bronco : Item
    {
        public bronco()
        {
            this.name = "Bronco Prime";

            this.pieces = new string[] { "Barrel", "Blueprint", "Receiver" };
            this.locations = new string[][] { new string[] { "Tower III Sabotage" }, new string[] { "Tower II Sabotage", "Tower II Survival C" }, new string[] { "Tower IV Capture", "Tower IV Survival B" } };
            this.chances = new double[][] { new double[] { 5.53 }, new double[] { 25.81, 19.36 }, new double[] { 19.36, 25 } };
        }
    }

    class burston : Item
    {
        public burston()
        {
            this.name = "Burston Prime";

            this.pieces = new string[] { "Barrel", "Blueprint", "Receiver", "Stock" };
            this.locations = new string[][] { new string[] { "Derelict Survival C", "Tower III Capture" }, new string[] { "Tower II Mobile Defense", "Tower III Defense B" }, new string[] { "Tower II Survival C", "Tower III Mobile Defense", "Tower IV Defense C" }, new string[] { "Tower I Exterminate", "Tower I Survival C", "Tower II Defense B" } };
            this.chances = new double[][] { new double[] { 19.36, 25.81 }, new double[] { 19.36, 20 }, new double[] { 7.52, 25.81, 19.36 }, new double[] { 25.81, 25.81, 25 } };
        }
    }

    class carrier : Item
    {
        public carrier()
        {
            this.name = "Carrier Prime";

            this.pieces = new string[] { "Blueprint", "Carapace", "Cerebrum", "Systems" };
            this.locations = new string[][] { new string[] { "Tower III Survival C", "Tower IV Interception A" }, new string[] { "Tower IV Defense C" }, new string[] { "Tower II Exterminate" }, new string[] { "Tower I Defense C", "Tower IV Defense B", "Tower IV Sabotage" } };
            this.chances = new double[][] { new double[] { 25.29, 25 }, new double[] { 19.36 }, new double[] { 7.52 }, new double[] { 25.81, 25, 15.49 } };
        }
    }

    class kamas : Item
    {
        public kamas()
        {
            this.name = "Dual Kamas Prime";

            this.pieces = new string[] { "Blade x2", "Blueprint", "Handle x2" };
            this.locations = new string[][] { new string[] { "Tower III Capture" }, new string[] { "Tower III Survival C" }, new string[] { "Derelict Defense C" } };
            this.chances = new double[][] { new double[] { 5.64 }, new double[] { 25.29 }, new double[] { 7.52 } };
        }
    }

    class fang : Item
    {
        public fang()
        {
            this.name = "Fang Prime";

            this.pieces = new string[] { "Blade x2", "Blueprint", "Handle x2" };
            this.locations = new string[][] { new string[] { "Tower II Survival B", "Tower III Survival A" }, new string[] { "Tower II Defense C", "Tower III Survival A" }, new string[] { "Tower II Defense C", "Tower IV Interception C" } };
            this.chances = new double[][] { new double[] { 20, 20 }, new double[] { 20, 20 }, new double[] { 20, 14.29 } };
        }
    }

    class forma : Item
    {
        public forma()
        {
            this.name = "Forma";

            this.pieces = new string[] { "Blueprint", "Forma" };
            this.locations = new string[][] { new string[] { "Derelict Survival C", "Tower I Capture", "Tower I Defense C", "Tower I Exterminate", "Tower I Mobile Defense", "Tower II Capture", "Tower II Exterminate", "Tower II Survival A", "Tower III Capture", "Tower III Defense C", "Tower III Mobile Defense", "Tower III Sabotage", "Tower IV Capture", "Tower IV Defense A", "Tower IV Exterminate", "Tower IV Interception B", "Tower IV Interception C", "Tower IV Mobile Defense", "Tower IV Sabotage", "Tower IV Survival C" }, new string[] { "Tower III Sabotage", "Tower III Survival C" } };
            this.chances = new double[][] { new double[] { 11.28, 5.64, 11.28, 7.52, 7.52, 14.29, 19.36, 20, 25.81, 19.36, 25.81, 25.29, 19.36, 20, 5.64, 25, 14.29, 16.67, 7.52, 14.19 }, new double[] { 2.01, 2.01 } };
        }
    }
    
    class hikou : Item
    {
        public hikou()
        {
            this.name = "Hikou Prime";

            this.pieces = new string[] { "Blueprint", "Pouch x2", "Stars x2" };
            this.locations = new string[][] { new string[] { "Tower II Sabotage", "Tower II Survival B", "Tower IV Interception B" }, new string[] { "Tower II Sabotage", "Tower IV Defense C", "Tower IV Exterminate" }, new string[] { "Tower I Defense C", "Tower I Sabotage" } };
            this.chances = new double[][] { new double[] { 25.81, 20, 25 }, new double[] { 25.81, 19.36, 25.81 }, new double[] { 25.81, 19.36 } };
        }
    }

    class kavasa : Item
    {
        public kavasa()
        {
            this.name = "Kavasa Prime";

            this.pieces = new string[] { "Collar Band", "Collar Blueprint", "Collar Buckle" };
            this.locations = new string[][] { new string[] { "Tower IV Sabotage" }, new string[] { "Tower IV Mobile Defense" }, new string[] { "Tower IV Exterminate" } };
            this.chances = new double[][] { new double[] { 7.52 }, new double[] { 16.67 }, new double[] { 5.64 } };
        }
    }

    class lex : Item
    {
        public lex()
        {
            this.name = "Lex Prime";

            this.pieces = new string[] { "Barrel", "Blueprint", "Receiver" };
            this.locations = new string[][] { new string[] { "Tower III Capture", "Tower III Survival B", "Tower IV Survival B" }, new string[] { "Tower III Defense B", "Tower IV Defense A" }, new string[] { "Tower I Capture", "Tower II Defense C", "Tower IV Interception C" } };
            this.chances = new double[][] { new double[] { 25.81, 20, 25 }, new double[] { 20, 20 }, new double[] { 5.64, 20, 14.29 } };
        }
    }

    class loki : Item
    {
        public loki()
        {
            this.name = "Loki Prime";

            this.pieces = new string[] { "Blueprint", "Chasis Blueprint", "Helmet Blueprint", "Systems Blueprint" };
            this.locations = new string[][] { new string[] { "Tower II Capture", "Tower II Sabotage", "Tower IV Interception A" }, new string[] { "Tower IV Sabotage", "Tower IV Survival C" }, new string[] { "Tower III Sabotage", "Tower IV Sabotage", "Tower IV Survival C" }, new string[] { "Tower III Sabotage", "Tower IV Defense C" } };
            this.chances = new double[][] { new double[] { 14.29, 5.64, 25 }, new double[] { 15.49, 14.19 }, new double[] { 25.29, 7.52, 14.19 }, new double[] { 5.53, 5.64 } };
        }
    }

    class nikana : Item
    {
        public nikana()
        {
            this.name = "Nikana Prime";

            this.pieces = new string[] { "Blade", "Blueprint", "Hilt" };
            this.locations = new string[][] { new string[] { "Tower II Survival C" }, new string[] { "Tower III Exterminate" }, new string[] { "Tower III Capture" } };
            this.chances = new double[][] { new double[] { 7.52 }, new double[] { 5.64 }, new double[] { 5.64 } };
        }
    }

    class nova : Item
    {
        public nova()
        {
            this.name = "Nova Prime";

            this.pieces = new string[] { "Blueprint", "Chasis Blueprint", "Helmet Blueprint", "Systems Blueprint"};
            this.locations = new string[][] { new string[] { "Tower I Sabotage", "Tower II Exterminate" }, new string[] { "Tower III Survival C" }, new string[] { "Tower I Survival C", "Tower IV Sabotage" }, new string[] { "Derelict Survival C" } };
            this.chances = new double[][] { new double[] { 19.36, 19.36 }, new double[] { 5.53 }, new double[] { 25.81, 15.49 }, new double[] { 11.28 } };
        }
    }

    class nyx : Item
    {
        public nyx()
        {
            this.name = "Nyx Prime";

            this.pieces = new string[] { "Blueprint", "Chasis Blueprint", "Helmet Blueprint", "Systems Blueprint" };
            this.locations = new string[][] { new string[] { "Tower II Capture", "Tower IV Defense C" }, new string[] { "Tower III Exterminate" }, new string[] { "Tower II Mobile Defense", "Tower II Sabotage" }, new string[] { "Tower III Exterminate", "Tower IV Capture", "Tower IV Sabotage" } };
            this.chances = new double[][] { new double[] { 14.29, 5.64 }, new double[] { 5.64 }, new double[] { 11.28, 5.64 }, new double[] { 38.72, 19.36, 15.49 } };
        }
    }

    class odonata : Item
    {
        public odonata()
        {
            this.name = "Odonata Prime";

            this.pieces = new string[] { "Blueprint", "Harness Blueprint", "Systems Blueprint", "Wings Blueprint" };
            this.locations = new string[][] { new string[] { "Tower I Capture", "Tower IV Defense C" }, new string[] { "Tower I Sabotage", "Tower IV Exterminate" }, new string[] { "Tower I Sabotage", "Tower I Survival A" }, new string[] { "Tower IV Survival C" } };
            this.chances = new double[][] { new double[] { 5.64, 19.36 }, new double[] { 11.28, 25.81 }, new double[] { 19.36, 16.67 }, new double[] { 14.19 } };
        }
    }

    class orthos : Item
    {
        public orthos()
        {
            this.name = "Orthos Prime";

            this.pieces = new string[] { "Blade x2", "Blueprint", "Handle" };
            this.locations = new string[][] { new string[] { "Tower II Capture", "Tower II Defense A" }, new string[] { "Tower II Extermiante", "Tower IV Survival B" }, new string[] { "Tower II Capture", "Tower IV Defense A" } };
            this.chances = new double[][] { new double[] { 14.29, 20 }, new double[] { 7.52, 25 }, new double[] { 14.29, 20 } };
        }
    }

    class paris : Item
    {
        public paris()
        {
            this.name = "Paris Prime";

            this.pieces = new string[] { "Blueprint", "Grip", "Lower Limb", "String", "Upper Limb" };
            this.locations = new string[][] { new string[] { "Tower II Defense B", "Tower II Survival C" }, new string[] { "Tower I Capture", "Tower IV Interception C" }, new string[] { "Tower I Survival C", "Tower II Survival A" }, new string[] { "Tower I Capture", "Tower II Capture", "Tower III Defense B" }, new string[] { "Tower I Survival C", "Tower II Defense C" } };
            this.chances = new double[][] { new double[] { 25, 19.36 }, new double[] { 5.64, 14.29 }, new double[] { 25.81, 20 }, new double[] { 25.81, 14.29, 20 }, new double[] { 7.52, 20 } };
        }
    }

    class saryn : Item
    {
        public saryn()
        {
            this.name = "Saryn Prime";

            this.pieces = new string[] { "Blueprint", "Chasis Blueprint", "Helmet Blueprint", "Systems Blueprint" };
            this.locations = new string[][] { new string[] { "Tower III Extermiante", "Tower IV Exterminate" }, new string[] { "Tower III Survival C" }, new string[] { "Tower I Mobile Defense" }, new string[] { "Tower II Exterminate" } };
            this.chances = new double[][] { new double[] { 5.64, 5.64 }, new double[] { 5.53 }, new double[] { 7.52 }, new double[] { 19.36 } };
        }
    }

    class scindo : Item
    {
        public scindo()
        {
            this.name = "Scindo Prime";

            this.pieces = new string[] { "Blade", "Blueprint", "Handle" };
            this.locations = new string[][] { new string[] { "Tower III Mobile Defense", "Tower III Sabotage" }, new string[] { "Tower I Extermiante" }, new string[] { "Tower I Sabotage", "Tower I Survival C" } };
            this.chances = new double[][] { new double[] { 5.64, 5.53 }, new double[] { 7.52 }, new double[] { 11.28, 7.52 } };
        }
    }

    class soma : Item
    {
        public soma()
        {
            this.name = "Soma Prime";

            this.pieces = new string[] { "Barrel", "Blueprint", "Receiver", "Stock" };
            this.locations = new string[][] { new string[] { "Tower III Mobile Defense", "Tower III Sabotage", "Tower IV Interception C" }, new string[] { "Tower II Defense A", "Tower II Survival B" }, new string[] { "Tower II Survival C" }, new string[] { "Derelict Defense C", "Tower III Exterminate" } };
            this.chances = new double[][] { new double[] { 25.81, 25.29, 14.29 }, new double[] { 20, 20 }, new double[] { 7.52 }, new double[] { 12.91, 5.64 } };
        }
    }

    class spira : Item
    {
        public spira()
        {
            this.name = "Spira Prime";

            this.pieces = new string[] { "Blade x2", "Blueprint", "Pouch x2" };
            this.locations = new string[][] { new string[] { "Tower III Mobile Defense" }, new string[] { "Tower IV Mobile Defense" }, new string[] { "Tower III Capture" } };
            this.chances = new double[][] { new double[] { 5.64 }, new double[] { 16.67 }, new double[] { 5.64 } };
        }
    }

    class trinity : Item
    {
        public trinity()
        {
            this.name = "Trinity Prime";

            this.pieces = new string[] { "Blueprint", "Chasis Blueprint", "Helmet Blueprint", "Systems Blueprint" };
            this.locations = new string[][] { new string[] { "Derelict Defense C", "Tower IV Defense C" }, new string[] { "Tower II Survival C", "Tower III Defense A" }, new string[] { "Tower II Sabotage" }, new string[] { "Tower III Mobile Defense" } };
            this.chances = new double[][] { new double[] { 12.91, 5.64 }, new double[] { 19.36, 25 }, new double[] { 5.64 }, new double[] { 5.64 } };
        }
    }
    
    class vasto : Item
    {
        public vasto()
        {
            this.name = "Vasto Prime";

            this.pieces = new string[] { "Barrel", "Blueprint", "Receiver" };
            this.locations = new string[][] { new string[] { "Tower I Sabotage", "Tower II Mobile Defense" }, new string[] { "Tower II Mobile Defense", "Tower IV Survival C" }, new string[] { "Tower I Defense C", "Tower III Extermiante", "Tower IV Mobile Defense" } };
            this.chances = new double[][] { new double[] { 19.36, 19.36 }, new double[] { 11.28, 14.19 }, new double[] { 11.28, 38.72, 16.67 } };
        }
    }

    class vectis : Item
    {
        public vectis()
        {
            this.name = "Vectis Prime";

            this.pieces = new string[] { "Barrel", "Blueprint", "Receiver", "Stock" };
            this.locations = new string[][] { new string[] { "Tower III Survival B", "Tower IV Interception B" }, new string[] { "Tower I Mobile Defense" }, new string[] { "Tower IV Extermiante" }, new string[] { "Tower III Mobile Defense" } };
            this.chances = new double[][] { new double[] { 20, 25 }, new double[] { 7.52 }, new double[] { 5.64 }, new double[] { 5.64 } };
        }
    }

    class volt : Item
    {
        public volt()
        {
            this.name = "Volt Prime";

            this.pieces = new string[] { "Blueprint", "Chasis Blueprint", "Helmet Blueprint", "Systems Blueprint" };
            this.locations = new string[][] { new string[] { "Tower II Capture", "Tower IV Capture" }, new string[] { "Tower III Survival C" }, new string[] { "Tower II Exterminate", "Tower III Survival B" }, new string[] { "Tower I Survival C" } };
            this.chances = new double[][] { new double[] { 14.29, 11.28 }, new double[] { 5.53 }, new double[] { 19.36, 20 }, new double[] { 7.52 } };
        }
    }

    class wyrm : Item
    {
        public wyrm()
        {
            this.name = "Wyrm Prime";

            this.pieces = new string[] { "Blueprint", "Carapace", "Cerebrum", "Systems" };
            this.locations = new string[][] { new string[] { "Tower II Extermiante" }, new string[] { "Tower II Sabotage", "Tower III Sabotage" }, new string[] { "Tower I Exterminate", "Tower III Defense C" }, new string[] { "Tower IV Defense A", "Tower IV Interception C" } };
            this.chances = new double[][] { new double[] { 7.52 }, new double[] { 5.64, 5.53 }, new double[] { 7.52, 19.36 }, new double[] { 20, 14.29 } };

        }
    }
}

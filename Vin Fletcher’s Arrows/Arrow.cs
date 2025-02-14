//Biruk Simachew
//2/13/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vin_Fletcher_s_Arrows
{
    public enum ArrowheadType
    {
        Steel,
        Wood,
        Obsidian
    }

    public enum FletchingType
    {
        Plastic,
        TurkeyFeathers,
        GooseFeathers
    }

    public class Arrow
    {
        // Vin’s Trouble homework question part 2
        private ArrowheadType arrowhead;
        private FletchingType fletching;
        private float length;

        public Arrow(ArrowheadType arrowhead, FletchingType fletching, float length)
        {
            this.arrowhead = arrowhead;
            this.fletching = fletching;
            this.length = length;
        }

        // Vin’s Trouble homework question part 3
        public ArrowheadType Arrowhead
        {
            get { return arrowhead; }
        }

        // Vin’s Trouble homework question part 3
        public FletchingType Fletching
        {
            get { return fletching; }
        }

        // Vin’s Trouble homework question part 3
        public float Length
        {
            get { return length; }
        }

        /*
        // Vin’s Trouble homework question part 2
        public ArrowheadType GetArrowhead()
        {
            return arrowhead;
        }

        // Vin’s Trouble homework question part 2
        public FletchingType GetFletching()
        {
            return fletching;
        }

        // Vin’s Trouble homework question part 2
        public float GetLength()
        {
            return length;
        }
        */

        public float CalculateCost()
        {
            float arrowheadCost = arrowhead switch
            {
                ArrowheadType.Steel => 10,
                ArrowheadType.Wood => 3,
                ArrowheadType.Obsidian => 5,
                _ => 0
            };

            float fletchingCost = fletching switch
            {
                FletchingType.Plastic => 10,
                FletchingType.TurkeyFeathers => 5,
                FletchingType.GooseFeathers => 3,
                _ => 0
            };

            float shaftCost = length * 0.05f;

            return arrowheadCost + fletchingCost + shaftCost;
        }
    }
}

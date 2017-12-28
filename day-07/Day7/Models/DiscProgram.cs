using System.Collections.Generic;
using System.Linq;
using System;

namespace Day7.Models
{
    public class DiscProgram
    {
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public int TotalWeight { get; private set; }
        public DiscProgram Parent { get; set; }
        public HashSet<DiscProgram> Children { get; set; }

        public DiscProgram(string name, int weight = 0)
        {
            Name = name;
            Weight = weight;
            TotalWeight = weight;
            Children = new HashSet<DiscProgram>();
        }

        public void AddChild(DiscProgram newChild)
        {
            // Set the child's parent value.
            newChild.Parent = this;

            // Add this to the current node's children.
            this.Children.Add(newChild);

            // Recalculate the total weight.
            this.RecalculateTotalWeight();
        }

        public void SetWeight(int weight)
        {
            this.Weight = weight;
            this.RecalculateTotalWeight();
        }

        public void RecalculateTotalWeight()
        {
            // Update this disc's total weight.
            this.TotalWeight = this.Weight + this.Children.Aggregate(0, (sum, child) => sum += child.TotalWeight);

            // Update the parent as well.
            if (this.Parent != null)
            {
                this.Parent.RecalculateTotalWeight();
            }
        }

        public override bool Equals(object obj)
        {
            DiscProgram other = obj as DiscProgram;

            if (other == null)
            {
                return false;
            }
            else
            {
                return this.Name.Equals(other.Name);
            }
        }

        public override int GetHashCode()
        {
            return (this.Name + this.Weight.ToString()).GetHashCode();
        }
    }
}
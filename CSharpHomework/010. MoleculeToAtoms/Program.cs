using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010.MoleculeToAtoms
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static Dictionary<string, int> ParseMolecule(string formula)
        {
            Dictionary<string, int> parsedMolecules = new Dictionary<string, int>();

            for (int i = 0; i < formula.Length; i++)
            {
                char currentChar = formula[i];
                if (char.IsLetter(currentChar))
                {
                    int moleculeCount = 1;
                    if(i + 1 != formula.Length - 1 && char.IsDigit(formula[i + 1]))
                    {
                        moleculeCount = formula[i + 1] - '0';
                    }

                    InitializeElement(parsedMolecules, currentChar.ToString(), moleculeCount);
                }
            }

            return parsedMolecules;
        }

        public static void InitializeElement(Dictionary<string, int> collection, string elementKey, int elementValue = 1)
        {
            if (!collection.ContainsKey(elementKey))
            {
                collection.Add(elementKey, elementValue);
            }
        }

    }
}

// For a given chemical formula represented by a string, count the number of atoms of each element contained 
// in the molecule and return an object (associative array in PHP, Dictionary<string, int> in C#, Map in Java).
// Examples:
//  Kata.ParseMolecule("H2O"); // => new Dictionary<string, int> {{"H", 2}, {"O", 1}}
//  Kata.ParseMolecule("Mg(OH)2"); // => new Dictionary<string, int> {{"Mg", 1}, {"O", 2}, {"H", 2}}
//  Kata.ParseMolecule("K4[ON(SO3)2]2"); // => new Dictionary<string, int> {{"K", 4}, {"O", 14}, {"N", 2}, {"S", 4}}

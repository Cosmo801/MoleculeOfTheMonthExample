using MoleculeOfTheMonth.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoleculeOfTheMonth.Processing
{
    public class CMLChemicalFileProcessor : IChemicalFileProcessor
    {
        public ChemicalModel ProcessChemicalFile(string fileData)
        {
            Console.WriteLine("##### CML Chemical File Processor");

            return new ChemicalModel();
        }
    }
}

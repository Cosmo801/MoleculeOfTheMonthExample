using MoleculeOfTheMonth.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoleculeOfTheMonth.Processing
{
    public interface IChemicalFileProcessor
    {
        ChemicalModel ProcessChemicalFile(string fileData);
    }
}

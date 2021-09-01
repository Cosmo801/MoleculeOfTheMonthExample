using System;
using System.Collections.Generic;
using System.Text;

namespace MoleculeOfTheMonth.Getter
{
    public interface IChemicalFileGetter
    {
        ChemicalFileResult GetChemicalFile(); 
    }
}

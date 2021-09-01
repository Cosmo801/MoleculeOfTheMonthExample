using System;
using System.Collections.Generic;
using System.Text;

namespace MoleculeOfTheMonth.Rendering
{
    public interface IChemicalModelRenderer
    {
        void RenderChemicalModel(ChemicalModel model);
    }
}

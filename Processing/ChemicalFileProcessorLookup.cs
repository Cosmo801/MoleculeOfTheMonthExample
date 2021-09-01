using MoleculeOfTheMonth.Getter;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoleculeOfTheMonth.Processing
{
    public class ChemicalFileProcessorLookup
    {
        static ChemicalFileProcessorLookup()
        {
            SetupData();
        }

        public static IChemicalFileProcessor GetProcessorForFormat(ChemicalFormat chemicalFormat)
        {
            return _formatDictionary[chemicalFormat];
        }

        private static void SetupData()
        {
            _formatDictionary = new Dictionary<ChemicalFormat, IChemicalFileProcessor>();
            _formatDictionary.Add(ChemicalFormat.CML, new CMLChemicalFileProcessor());

        }

        private static Dictionary<ChemicalFormat, IChemicalFileProcessor> _formatDictionary;


    }
}

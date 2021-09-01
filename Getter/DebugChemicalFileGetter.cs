using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MoleculeOfTheMonth.Getter
{
    public class DebugChemicalFileGetter : IChemicalFileGetter
    {
        public ChemicalFileResult GetChemicalFile()
        {
            string path = "../../../Resources/methanol.cml";
            string fileData = "";
            using (StreamReader reader = File.OpenText(path))
            {
                fileData = reader.ReadToEnd();
            }

            return new ChemicalFileResult { ChemicalFileFormat = ChemicalFormat.CML, FileData = fileData };
        }
    }
}

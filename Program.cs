using MoleculeOfTheMonth.Getter;
using MoleculeOfTheMonth.Processing;
using MoleculeOfTheMonth.Rendering;
using System;

namespace MoleculeOfTheMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. GETTING THE FILE */

            //GET MOLECULE OF THE MONTH FILE FROM API
            //WebChemicalFileGetter - Get molecule of the month from api
            IChemicalFileGetter getter = new DebugChemicalFileGetter();

            //Chemical File result contains the file itself and the format
            ChemicalFileResult result = getter.GetChemicalFile();

            /*2 PROCESSING THE FILE */
            //For the chemical file format get the right processor
            //The processor is dependent on the ChemicalFileFormat enumeration
            IChemicalFileProcessor fileProcessor = ChemicalFileProcessorLookup.GetProcessorForFormat(result.ChemicalFileFormat);

            /* ABOVE THIS LINE IS PRETTY STRAIGHTFORWARD - UNDER IT IS THE STUFF WE NEED TO FIGURE OUT */

            /* 3 RENDERING THE MOLECULE */
            //Produce the model that we will later render
            //The file processing could be performed by some already existing library
            //https://docs.eyesopen.com/toolkits/csharp/oechemtk/ or https://apidocs.chemaxon.com/dotNET/6.3/examples.html - But these require early versions of .net framework
            //Might be easier to just write them ourselves
            ChemicalModel model = fileProcessor.ProcessChemicalFile(result.FileData);

            //Render the file - heres where unity kicks in
            IChemicalModelRenderer renderer = new BallAndStickChemicalModelRenderer();
            renderer.RenderChemicalModel(model);
        }
    }
}

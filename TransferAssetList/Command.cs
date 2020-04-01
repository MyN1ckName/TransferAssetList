using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;

namespace TransferAssetList
{
	[TransactionAttribute(TransactionMode.Manual)]
	[RegenerationAttribute(RegenerationOption.Manual)]
	public class Command : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData,
			ref string messege,
			ElementSet elements)
		{
			RevitManager revitManager = new RevitManager(commandData);

			return Result.Succeeded;
		}
	}
}
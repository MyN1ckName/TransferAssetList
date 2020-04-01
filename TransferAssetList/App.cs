using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;

namespace TransferAssetList
{
	class App : IExternalApplication
	{
		public Result OnStartup(UIControlledApplication a)
		{
			a.ViewActivated += OnViewActivated;

			return Result.Succeeded;
		}

		private void OnViewActivated(object sender, ViewActivatedEventArgs e)
		{
			
		}

		public Result OnShutdown(UIControlledApplication a)
		{
			return Result.Succeeded;
		}
	}
}
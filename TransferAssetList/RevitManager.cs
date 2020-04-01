using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace TransferAssetList
{
	class RevitManager
	{
		public static UIApplication uiApplication;
		public static Application app;
		public static UIDocument uiDoc;
		public static Document doc;
		public static WorksetTable worksetTable;

		public RevitManager(ExternalCommandData commandData)
		{
			uiApplication = commandData.Application;
			app = uiApplication.Application;
			uiDoc = uiApplication.ActiveUIDocument;
			doc = uiDoc.Document;
			worksetTable = doc.GetWorksetTable();
		}
	}
}
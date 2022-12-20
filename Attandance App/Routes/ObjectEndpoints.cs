using Attandance_App.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attandance_App.Routes
{
    public static class ObjectEndpoints
    {
        public static string SideMenuURL = BaseEndpoint.BaseURL + "Object/FetchSideMenu";
        public static string FormDefinitionURL = "Object/FetchObjects";
        public static string GetPinnedMenusEndpoint = "Object/FilterPinnedUnpinnedMenu";
        public static string UpdatePinnedMenusEndpoint = "Object/UpdatePinnedUnpinnedMenu";
        public static string LoadAllObjectsForUserConfigEndPoint = "Object/LoadObjectsForUserConfiguration";
        public static string UpdateAllObjectsForUserConfigEndPoint = "Object/UpdateObjectsForUserConfiguration";

        //public static string SideMenuURL = BaseEndpoint.BaseURL + "Object/fetchSideMenu";
        //public static string FormDefinitionURL = "Object/fetchObjects";
        //public static string GetPinnedMenusEndpoint = "Object/filterPinnedUnpinnedMenu";
        //public static string UpdatePinnedMenusEndpoint = "Object/updatePinnedUnpinnedMenu";
    }

}

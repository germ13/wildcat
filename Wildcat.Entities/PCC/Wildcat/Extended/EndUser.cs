namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class EndUser
    {
        //public static EndUser GetUserById(int userId)
        //{
        //    using (var context = new WildcatContext())
        //    {
        //        var user =  context.EndUser.Where(u => u.EndUserId == userId).FirstOrDefault();
        //        user.EndUserToLocation = context.EndUserToLocation.Where(u => u.EndUserId == user.EndUserId).ToList();
        //        return user;
        //    }
        //}

        //public static EndUser GetUserByName(string AppLoginName)
        //{
        //    using (var context = new WildcatContext())
        //    {
        //        var user =  context.EndUser.Where(u => u.AppLoginName == AppLoginName).FirstOrDefault();

        //        //get rid of null this when we have the enduser table applogin property filled. created 01/29/2019
        //        if(user == null)
        //        {
        //            //gett he user name by split
        //            var usern = AppLoginName.Replace(@"PRECASTCORP\", string.Empty);
        //            user = context.EndUser.Where(x => x.DisplayName == usern).FirstOrDefault();
        //            if(user != null)
        //            {
        //                user.AppLoginName = AppLoginName;
        //                context.SaveChanges();
        //            }
        //        }
        //        user.EndUserToLocation = context.EndUserToLocation.Where(u => u.EndUserId == user.EndUserId).ToList();
        //        return user;
        //    }
        //}

        //public static string GetSelectedLocation(HttpContext context)
        //{
        //    string LocationCode;
        //    var user = GetUserByName(context.User.Identity.Name);
        //    //EndUser user = EndUser.GetUserByName(@"PRECASTCORP\mark.gerlach");

        //    if (string.IsNullOrEmpty(context.Request.Cookies["SelectedLocation"]))
        //    {
        //        using (var db = new WildcatContext())
        //        {
        //            LocationCode = db.EndUserToLocation.Where(u => u.EndUserId == user.EndUserId).FirstOrDefault().LocationCode;
        //        }
        //    }
        //    else
        //    {
        //        LocationCode = context.Request.Cookies["SelectedLocation"];
        //    }
        //    return LocationCode;
        //}

        //public static List<Location> GetUserLocationsByName(int EndUserID)
        //{
        //    List<EndUserToLocation> UserLocations = new List<EndUserToLocation>();
        //    using (var db = new WildcatContext())
        //    {
        //        UserLocations = db.EndUserToLocation.Where(u => u.EndUserId == EndUserID).ToList();
        //    }
        //    using (var db = new WildcatContext())
        //    {
        //        List<Location> locations = new List<Location>();
        //        foreach(var l in UserLocations)
        //        {
        //            locations.Add(db.Location.Where(u => u. == EndUserID))
        //        }
        //        return .ToList();
        //    }

        //}
        //private static List<SelectListItem> GetUserLocations(EndUser user, ICollection<EndUserToLocation> endUserToLocation)
        //{
        //    List<SelectListItem> UserLocations = new List<SelectListItem>();
        //    foreach(var i in endUserToLocation)
        //    {
        //        bool selected = user.SelectedLocation == i.LocationCode ? true : false;
        //        UserLocations.Add(new SelectListItem
        //        {
        //            Text = i.LocationCode,
        //            Value = i.LocationCode,
        //            Selected = selected,
        //        });
        //    }
        //    return UserLocations;
        //}
    }
}


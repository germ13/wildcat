using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Wildcat.Entities.PCC.Wildcat;

namespace Wildcat.App.Utilities
{
    //TODO what is the purpose of this?  Can it be cleaned up?


        public class WildcatUser
        {
            private readonly WildcatContext _context;

            public WildcatUser(WildcatContext context)
            {
                _context = context;
            }

            #region Public Methods

            public EndUser GetUserById(string userId) //TODO changed to stringsee if trickle down
            {
                EndUser user;
                user = _context.EndUser.Where(u => u.AppLoginName == userId).FirstOrDefault();
                user.EndUserToLocation = _context.EndUserToLocation.Where(u => u.AppLoginName == user.AppLoginName).ToList();
                return user;
            }

            public EndUser GetUserByName(string AppLoginName)
            {
                var user = _context.EndUser.Where(u => u.AppLoginName == AppLoginName).FirstOrDefault();

                //get rid of null this when we have the enduser table applogin property filled. created 01/29/2019
                if (user == null)
                {
                    //gett he user name by split
                    var usern = AppLoginName.Split(@"\");
                    user = _context.EndUser.Where(x => x.DisplayName == usern[1]).FirstOrDefault();
                    if (user != null)
                    {
                        user.AppLoginName = AppLoginName;
                        _context.SaveChanges();
                    }
                }
                user.EndUserToLocation = _context.EndUserToLocation.Where(u => u.AppLoginName == user.AppLoginName).ToList();
                return user;
            }

            public string GetSelectedLocation(HttpContext context)
            {
                string LocationCode;
                var user = GetUserByName(context.User.Identity.Name);
                //EndUser user = EndUser.GetUserByName(@"PRECASTCORP\mark.gerlach");

                if (string.IsNullOrEmpty(context.Request.Cookies["SelectedLocation"]))
                {
                    LocationCode = _context.EndUserToLocation.Where(u => u.AppLoginName == user.AppLoginName).FirstOrDefault().LocationCode;
                }
                else
                {
                    LocationCode = context.Request.Cookies["SelectedLocation"];
                }
                return LocationCode;
            }

            public static string GetCurrentLocation(HttpContext context)
            {
                //string LocationCode;
                //var user = GetUserByName(context.User.Identity.Name);
                ////EndUser user = EndUser.GetUserByName(@"PRECASTCORP\mark.gerlach");

                //if (string.IsNullOrEmpty(context.Request.Cookies["SelectedLocation"]))
                //{
                //    LocationCode = _context.EndUserToLocation.Where(u => u.AppLoginName == user.AppLoginName).FirstOrDefault().LocationCode;
                //}
                //else
                //{
                //    LocationCode = context.Request.Cookies["SelectedLocation"];
                //}
                return context.Request.Cookies["SelectedLocation"];
            }


            #endregion Public Methods
        }
    }
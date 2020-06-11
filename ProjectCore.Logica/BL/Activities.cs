using System.Collections.Generic;
using System.Linq;

namespace ProjectCore.Logica.BL
{
    public class Activities
    {
        public List<Models.DB.Activities> GetActivities()
        {
            ProyectCore.DAL.Models.ProyectCoreContext _context = new ProyectCore.DAL.Models.ProyectCoreContext();

            var listActivities = (from _activities in _context.Activities
                                  where _activities.Active == true
                                  select new Models.DB.Activities
                                  {
                                      Id = _activities.Id,
                                      Name = _activities.Name,
                                      Active = _activities.Active


                                  }).ToList();

            return listActivities;
            
        }

    }
}

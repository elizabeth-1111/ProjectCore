using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectCore.Logica.BL
{
    public class States
    {
        public List<Models.DB.States> GetStates()
        {
            ProyectCore.DAL.Models.ProyectCoreContext _context = new ProyectCore.DAL.Models.ProyectCoreContext();

            var listStates = (from _states in _context.States
                              where _states.Active == true
                              select new Models.DB.States
                              {
                                  Id = _states.Id,
                                  Name = _states.Name,
                                  Active = _states.Active


                              }).ToList();
            return listStates;
        }
    }
}

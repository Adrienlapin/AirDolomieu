using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirDolomieu.Class;

namespace AirDolomieu
{
    internal class Data
    {
        public Data()
        {
            AirDolomieuContext _context = new AirDolomieuContext();
        }

        //Return list vol for Pilote selected
        public List<ViewVol> GetViewVolsbyPilote(Pilote P)
        {
            List<ViewVol> list = new List<ViewVol>();
            using (AirDolomieuContext _context = new AirDolomieuContext())
            {
                var query =
                    from vol in _context.Vols
                    where vol.NumpiloteNavigation.Numpilote == P.Numpilote
                    select new ViewVol
                    {
                        Numvol = vol.Numvol,
                        Nompilote = vol.NumpiloteNavigation.Nompilote.Trim(),
                        Nomavion = vol.NumavionNavigation.Nomavion.Trim() + "-" + vol.NumavionNavigation.Numavion.ToString(),
                        Heuredep = vol.Heuredep,
                        Villedep = vol.Villedep,
                        Heurearr = vol.Heurearr,
                        Villearr = vol.Villearr
                    };

                return query.ToList();
            }

        }


        //Return List Vol for all plane selected
        public List<ViewVol> GetViewVolsbyAvion(Avion A)
        {
            List<ViewVol> list = new List<ViewVol>();
            using (AirDolomieuContext _context = new AirDolomieuContext())
            {
                var query =
                from vol in _context.Vols
                where vol.NumavionNavigation.Numavion == A.Numavion
                select new ViewVol
                {
                    Numvol = vol.Numvol,
                    Nompilote = vol.NumpiloteNavigation.Nompilote.Trim(),
                    Nomavion = vol.NumavionNavigation.Nomavion.Trim() + "-" + vol.NumavionNavigation.Numavion.ToString(),
                    Heuredep = vol.Heuredep,
                    Villedep = vol.Villedep,
                    Heurearr = vol.Heurearr,
                    Villearr = vol.Villearr
                };
                return query.ToList();
            }

            
        }

        //Return List Vol with plane and pilote selected
        public List<ViewVol> GetViewVolsbyAll(Pilote P, Avion A)
        {
            List<ViewVol> list = new List<ViewVol>();
            using (AirDolomieuContext _context = new AirDolomieuContext())
            {
                var query =
                from vol in _context.Vols
                where vol.NumpiloteNavigation.Numpilote == P.Numpilote && vol.NumavionNavigation.Numavion == A.Numavion
                select new ViewVol
                {
                    Numvol = vol.Numvol,
                    Nompilote = vol.NumpiloteNavigation.Nompilote.Trim(),
                    Nomavion = vol.NumavionNavigation.Nomavion.Trim() + "-" + vol.NumavionNavigation.Numavion.ToString(),
                    Heuredep = vol.Heuredep,
                    Villedep = vol.Villedep,
                    Heurearr = vol.Heurearr,
                    Villearr = vol.Villearr
                };
                return query.ToList();
            }
        }

        //return all table Pilote
        public ObservableCollection<Pilote> GetAllPilote()
        {
            List<Pilote> list = new List<Pilote>();
            ObservableCollection<Pilote> collection = new ObservableCollection<Pilote>();

            using (AirDolomieuContext _context = new AirDolomieuContext())
            {
                list = _context.Pilotes.ToList();
            }
            foreach (Pilote p in list)
            {
                p.Nompilote = p.Nompilote.Trim();
                collection.Add(p);

            }
            return collection;
        }

        //return all table Avion
        public ObservableCollection<Avion> GetAllAvion()
        {
            List<Avion> list = new List<Avion>();
            ObservableCollection<Avion> collection = new ObservableCollection<Avion>();

            using (AirDolomieuContext _context = new AirDolomieuContext())
            {
                list = _context.Avions.ToList();
            }
            foreach (Avion a in list)
            {
                a.Nomavion = a.Nomavion.Trim() +"-"+ a.Numavion.ToString();
                collection.Add(a);

            }
            return collection;
        }

        public Vol GetOneVol(Vol fly)
        {
            using (AirDolomieuContext _context = new AirDolomieuContext())
            {
                var query =
                from vol in _context.Vols
                where vol.Numvol == fly.Numvol
                select new Vol
                {
                    Numvol = vol.Numvol,
                    Numavion = vol.Numavion,
                    Numpilote = vol.Numpilote,
                    Heuredep = vol.Heuredep,
                    Villedep = vol.Villedep,
                    Heurearr = vol.Heurearr,
                    Villearr = vol.Villearr
                };
                if (query.ToList().Count == 0)
                {
                    return null;
                } else
                {
                    return query.ToList()[0];
                }
            }
        }

        //Ajouter un vol avec EntityFramework
        public String PutNewVol(Vol fly, Pilote P, Avion A)
        {
            String message = String.Empty;
            try
            {
                fly.Numavion = A.Numavion;
                fly.Numpilote = P.Numpilote;

                using (AirDolomieuContext _context = new AirDolomieuContext())
                {
                    _context.Vols.Add(fly);
                    _context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                message = ex.Message + "\n" + ex.StackTrace.ToString();
                return message;
            }
            message = "OK";
            return message;
            
        }

    }
}

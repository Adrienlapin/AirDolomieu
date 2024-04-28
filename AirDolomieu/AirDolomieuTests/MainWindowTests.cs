using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirDolomieu.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AirDolomieu.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
     

        [TestMethod()]
        public void MainWindowTest()
        {
            Console.WriteLine("START");           
            List<ViewVol> ListVol = new List<ViewVol>();

            Pilote P = new Pilote();
            P.Numpilote = 1;
           ListVol = GetViewVols(P);

            Console.WriteLine(ListVol.Count.ToString());

            Console.WriteLine("END");
            Assert.Fail();
        }

        public List<ViewVol> GetViewVols(Pilote P)
        {
            List<ViewVol> list2 = new List<ViewVol>();
            try
            {
                IEnumerable<ViewVol> list = new List<ViewVol>();
                using (AirDolomieuContext _context = new AirDolomieuContext())
                {
                    var query =
                        from vol in _context.Vols
                        join pilote in _context.Pilotes on vol.Numpilote equals pilote.Numpilote
                        join avion in _context.Avions on vol.Numavion equals avion.Numavion
                        where pilote.Numpilote == P.Numpilote
                        select new ViewVol
                        {
                            Numvol = vol.Numvol,
                            //Numpilote = vol.Numpilote,
                            Nompilote = pilote.Nompilote.Trim(),
                            //Numavion = vol.Numavion,
                            Nomavion = avion.Nomavion.Trim() + "-" + avion.Numavion,
                            Heuredep = vol.Heuredep,
                            Villedep = vol.Villedep,
                            Heurearr = vol.Heurearr,
                            Villearr = vol.Villearr
                        };
                    foreach (var item in query)
                    {
                        list2.Add(item);
                    }
                }       

                

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

         

            return list2;
        }
    }
}
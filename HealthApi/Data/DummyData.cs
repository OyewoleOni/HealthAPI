using HealthApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthApi.Data
{
    public class DummyData
    {
        public static List<Ailment> GetAilments()
        {
            List<Ailment> ailments = new List<Ailment>()
            {
                new Ailment{Name="Head Ache"},
                new Ailment{Name="Tummy Pain"},
                 new Ailment{Name="Flu"},
                  new Ailment{Name="Cold"},
            };
            return ailments;
        }

        public static List<Medication> GetMedications()
        {
            List<Medication> medications = new List<Medication>()
            {
                new Medication{Name="Tylenol", Doses="2"},
                new Medication{Name="Aspirin", Doses="4"},
                 new Medication{Name="Advil" , Doses="3"},
                  new Medication{Name="Robaxin", Doses="2"},
                   new Medication{Name="Voltarein", Doses="1"}
            };
            return medications;
        }
        public static List<Patient> GetMedications(HealthContext db)
        {
            List<Patient> patients = new List<Patient>()
            {
               new Patient
               {
                   Name="Ann Smith",
                   Ailments= new List<Ailment>(db.Ailments.Take(2)),
                   Medications = new List<Medication>(db.Medications.Take(2))
               },
               new Patient
               {
                   Name="Ann Smith",
                   Ailments= new List<Ailment>(db.Ailments.Take(2)),
                   Medications = new List<Medication>(db.Medications.Take(2))
               }, 
            };
            return patients;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlantillaPersonal.Modelos
{
    class ModeloCuenta
    {
        public Cuenta cuenta { get; set; }

         public ModeloCuenta() {

        }

        public void AgregarCuenta(Cuenta cuenta) {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities()) {
                entity.Cuenta.Add(cuenta);
                entity.SaveChanges();
            }

        }
    }
}

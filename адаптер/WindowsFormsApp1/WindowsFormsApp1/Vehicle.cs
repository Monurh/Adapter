using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    interface IVehicle
    {
        void Move();
    }

    class Car
    {
        public void Drive() => MessageBox.Show("Рух по дорозі з твердим покриттям");
    }

    class Camel
    {
        public void Walk() => MessageBox.Show("Ходьба по піску");
    }

    class Horse
    {
        public void Gallop() => MessageBox.Show("Галопом по траві");
    }

    class CarToCamelAdapter : IVehicle
    {
        private readonly Camel _camel;

        public CarToCamelAdapter(Camel camel) => _camel = camel;

        public void Move() => _camel.Walk();
    }

    class CamelToCarAdapter : IVehicle
    {
        private readonly Car _car;

        public CamelToCarAdapter(Car car) => _car = car;

        public void Move() => _car.Drive();
    }

    class CamelToHorseAdapter : IVehicle
    {
        private readonly Horse _horse;

        public CamelToHorseAdapter(Horse horse) => _horse = horse;

        public void Move() => _horse.Gallop();
    }

    class HorseToCamelAdapter : IVehicle
    {
        private readonly Camel _camel;

        public HorseToCamelAdapter(Camel camel) => _camel = camel;

        public void Move() => _camel.Walk();
    }
}
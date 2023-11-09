using SampleUnitConverter2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter2 {
    public class MainWindowViewModel : ViewModel {
        private double kilogramValue, pondValue;

        //↑ボタンで呼ばれるコマンド
        public ICommand PondUnitToKilogram { get; private set; }
        //↓ボタンで呼ばれるコマンド
        public ICommand KilogramToPondUnit { get; private set; }
        //上のComboBoxで選択されている値
        public KilogramUnit CurrentKilogramUnit { get; set; }   //metric
        //下のComboBoxで選択されている値
        public PondUnit CurrentPondUnit { get; set; }   //Imperial

        public double KilogramValue {
            get { return this.kilogramValue; }
            set {
                this.kilogramValue = value;
                this.OnPropertyChanged();
            }
        }

        public double PondValue {
            get { return this.pondValue; }
            set {
                this.pondValue = value;
                this.OnPropertyChanged();
            }
        }

        public MainWindowViewModel() {
            this.CurrentKilogramUnit = KilogramUnit.Units.First();
            this.CurrentPondUnit = PondUnit.Units.First();
            this.KilogramToPondUnit = new DelegateCommand(
                () => this.PondValue = this.CurrentPondUnit.FromKilogramUnit(
                    this.CurrentKilogramUnit, this.KilogramValue));
            this.PondUnitToKilogram = new DelegateCommand(
                () => this.KilogramValue = this.CurrentKilogramUnit.FromPondUnit(
                    this.CurrentPondUnit, this.PondValue));
        }
    }
}

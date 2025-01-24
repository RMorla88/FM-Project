using Fm_pj.Model;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fm_pj;

 /// <summary>
 /// Interaction logic for MainWindow.xaml
 /// </summary>
 public partial class MainWindow : Window
 {
   public MainWindow()
   {
      InitializeComponent();

      var lineup = new LineupModel();


		var dlb = lineup.fieldModel.fieldZoneDl.DefensiveBaseValue;
		var dcb = lineup.fieldModel.fieldZoneDc.DefensiveBaseValue;
		var drb = lineup.fieldModel.fieldZoneDr.DefensiveBaseValue;

		var clb = lineup.fieldModel.fieldZoneCl.BallControlBaseValue;
		var ccb = lineup.fieldModel.fieldZoneCc.BallControlBaseValue;
		var crb = lineup.fieldModel.fieldZoneCr.BallControlBaseValue;

		var alb = lineup.fieldModel.fieldZoneAl.AttackBaseValue;
		var acb= lineup.fieldModel.fieldZoneAc.AttackBaseValue;
		var arb = lineup.fieldModel.fieldZoneAr.AttackBaseValue;

		var dl = lineup.fieldModel.fieldZoneDl.DefensiveValue;
		var dc = lineup.fieldModel.fieldZoneDc.DefensiveValue;
		var dr = lineup.fieldModel.fieldZoneDr.DefensiveValue;

		var cl = lineup.fieldModel.fieldZoneCl.BallControlValue;
		var cc = lineup.fieldModel.fieldZoneCc.BallControlValue;
		var cr = lineup.fieldModel.fieldZoneCr.BallControlValue;

		var al = lineup.fieldModel.fieldZoneAl.AttackValue;
		var ac = lineup.fieldModel.fieldZoneAc.AttackValue;
		var ar = lineup.fieldModel.fieldZoneAr.AttackValue;
	}
 }
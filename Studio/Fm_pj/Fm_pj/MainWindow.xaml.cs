using Fm_pj.Model;
using System.Windows;

namespace Fm_pj;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
 {
   public MainWindow()
   {
      InitializeComponent();

      var lineup1 = new LineupModel();
		var lineup2 = new LineupModel();

      for (int i = 0; i < 10; i++)
      {
         var match = new MatchModel(lineup1, lineup2);
         match.MatchSimulation();
      }
	}
 }
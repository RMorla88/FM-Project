namespace Fm_pj.Model;

public class LineupModel
{
	public FieldModel fieldModel = new FieldModel();

	public LineupModel()
	{
		PlayerModel gk = new PlayerModel();
		PlayerModel dl = new PlayerModel();
		PlayerModel dc1 = new PlayerModel();
		PlayerModel dc2 = new PlayerModel();
		PlayerModel dr = new PlayerModel();
		PlayerModel cl = new PlayerModel();
		PlayerModel cc1 = new PlayerModel();
		PlayerModel cc2 = new PlayerModel();
		PlayerModel cr = new PlayerModel();
		PlayerModel ac1 = new PlayerModel();
		PlayerModel ac2 = new PlayerModel();

		fieldModel.fieldZoneDc.GoalKeeper = gk;
		fieldModel.fieldZoneDl.Players.Add(dl);
		fieldModel.fieldZoneDc.Players.Add(dc1);
		fieldModel.fieldZoneDc.Players.Add(dc2);
		fieldModel.fieldZoneDr.Players.Add(dr);
		fieldModel.fieldZoneCl.Players.Add(cl);
		fieldModel.fieldZoneCc.Players.Add(cc1);
		fieldModel.fieldZoneCc.Players.Add(cc2);
		fieldModel.fieldZoneCr.Players.Add(cr);
		fieldModel.fieldZoneAc.Players.Add(ac1);
		fieldModel.fieldZoneAc.Players.Add(ac2);

		fieldModel.CalculateBaseValues();
		fieldModel.CalculateValues();
	}
}

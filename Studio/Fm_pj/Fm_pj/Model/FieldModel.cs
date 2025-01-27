namespace Fm_pj.Model;

public class FieldModel
{
	public FieldZoneModel fieldZoneDl = new FieldZoneModel();
	public FieldZoneModel fieldZoneDc = new FieldZoneModel();
	public FieldZoneModel fieldZoneDr = new FieldZoneModel();
	public FieldZoneModel fieldZoneCl = new FieldZoneModel();
	public FieldZoneModel fieldZoneCc = new FieldZoneModel();
	public FieldZoneModel fieldZoneCr = new FieldZoneModel();
	public FieldZoneModel fieldZoneAl = new FieldZoneModel();
	public FieldZoneModel fieldZoneAc = new FieldZoneModel();
	public FieldZoneModel fieldZoneAr = new FieldZoneModel();

	public FieldModel()
	{
		fieldZoneDl.NearFieldZones.Add(fieldZoneDc);
		fieldZoneDl.NearFieldZones.Add(fieldZoneCl);
		fieldZoneDl.NearFieldZones.Add(fieldZoneCc);

		fieldZoneDc.NearFieldZones.Add(fieldZoneDl);
		fieldZoneDc.NearFieldZones.Add(fieldZoneDr);
		fieldZoneDc.NearFieldZones.Add(fieldZoneCl);
		fieldZoneDc.NearFieldZones.Add(fieldZoneCc);
		fieldZoneDc.NearFieldZones.Add(fieldZoneCr);

		fieldZoneDr.NearFieldZones.Add(fieldZoneDc);
		fieldZoneDr.NearFieldZones.Add(fieldZoneCc);
		fieldZoneDr.NearFieldZones.Add(fieldZoneCr);

		fieldZoneCl.NearFieldZones.Add(fieldZoneDl);
		fieldZoneCl.NearFieldZones.Add(fieldZoneDc);
		fieldZoneCl.NearFieldZones.Add(fieldZoneCc);
		fieldZoneCl.NearFieldZones.Add(fieldZoneAl);
		fieldZoneCl.NearFieldZones.Add(fieldZoneAc);

		fieldZoneCc.NearFieldZones.Add(fieldZoneDl);
		fieldZoneCc.NearFieldZones.Add(fieldZoneDc);
		fieldZoneCc.NearFieldZones.Add(fieldZoneDr);
		fieldZoneCc.NearFieldZones.Add(fieldZoneCl);
		fieldZoneCc.NearFieldZones.Add(fieldZoneCr);
		fieldZoneCc.NearFieldZones.Add(fieldZoneAl);
		fieldZoneCc.NearFieldZones.Add(fieldZoneAc);
		fieldZoneCc.NearFieldZones.Add(fieldZoneAr);

		fieldZoneCr.NearFieldZones.Add(fieldZoneDr);
		fieldZoneCr.NearFieldZones.Add(fieldZoneDc);
		fieldZoneCr.NearFieldZones.Add(fieldZoneCc);
		fieldZoneCr.NearFieldZones.Add(fieldZoneAc);
		fieldZoneCr.NearFieldZones.Add(fieldZoneAr);

		fieldZoneAl.NearFieldZones.Add(fieldZoneCl);
		fieldZoneAl.NearFieldZones.Add(fieldZoneCc);
		fieldZoneAl.NearFieldZones.Add(fieldZoneAc);

		fieldZoneAc.NearFieldZones.Add(fieldZoneCl);
		fieldZoneAc.NearFieldZones.Add(fieldZoneCc);
		fieldZoneAc.NearFieldZones.Add(fieldZoneCr);
		fieldZoneAc.NearFieldZones.Add(fieldZoneAr);
		fieldZoneAc.NearFieldZones.Add(fieldZoneAl);

		fieldZoneAr.NearFieldZones.Add(fieldZoneCr);
		fieldZoneAr.NearFieldZones.Add(fieldZoneCc);
		fieldZoneAr.NearFieldZones.Add(fieldZoneAc);
	}

	public void CalculateBaseValues()
	{
		fieldZoneDl.CalculateBaseValues();
		fieldZoneDr.CalculateBaseValues();
		fieldZoneDc.CalculateBaseValues();
		fieldZoneCc.CalculateBaseValues();
		fieldZoneCl.CalculateBaseValues();
		fieldZoneCr.CalculateBaseValues();
		fieldZoneAr.CalculateBaseValues();
		fieldZoneAc.CalculateBaseValues();
		fieldZoneCl.CalculateBaseValues();
	}

	public void CalculateValues()
	{
		fieldZoneDl.CalculateValues();
		fieldZoneDr.CalculateValues();
		fieldZoneDc.CalculateValues();
		fieldZoneCc.CalculateValues();
		fieldZoneCl.CalculateValues();
		fieldZoneCr.CalculateValues();
		fieldZoneAr.CalculateValues();
		fieldZoneAc.CalculateValues();
		fieldZoneAl.CalculateValues();
	}

	public void ResetValue()
	{
		fieldZoneDl.ResetValue();
		fieldZoneDr.ResetValue();
		fieldZoneDc.ResetValue();
		fieldZoneCc.ResetValue();
		fieldZoneCl.ResetValue();
		fieldZoneCr.ResetValue();
		fieldZoneAr.ResetValue();
		fieldZoneAc.ResetValue();
		fieldZoneAl.ResetValue();
	}
}


public class Rootobject
{
    public Class1[] Property1 { get; set; }
}

public class Class1
{
    public int MultiAtnDetKy { get; set; }
    public int AtnDetKy { get; set; }
    public DateTime? InDtm { get; set; }
    public DateTime? OutDtm { get; set; }
    public float INLatitude { get; set; }
    public float INLongitude { get; set; }
    public float OutLatitude { get; set; }
    public float OutLongitude { get; set; }
    public Location Location { get; set; }
    public float TTlMint { get; set; }
}

public class Location
{
    public int CodeKey { get; set; }
    public string Code { get; set; }
    public string ConditionCode { get; set; }
    public string CodeName { get; set; }
    public object CodeNameOnly { get; set; }
    public bool IsDefault { get; set; }
    public int IsActive { get; set; }
    public int IsApproved { get; set; }
}

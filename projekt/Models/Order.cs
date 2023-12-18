public class Order
{
    public int OrderID { get; set; }
    public int UserID { get; set; }
    public string ImageURL { get; set; }
    public string MosaicType { get; set; }
    public string FrameSize { get; set; }
    public string FrameColor { get; set; }
    public DateTime OrderDate { get; set; }
    public string Status { get; set; }
}

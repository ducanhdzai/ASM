namespace ASM.Models
{
    public class BillDetail
    {
        public Guid ID { get; set; }
        public Guid IDSP { get; set; }
        public Guid IDHD { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
    }
}
namespace ASM.Models
{
    public class User
    {
         public Guid UserID { get; set; }
         public Guid RoleID { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public int Status { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual Cart Cart { get; set; }


    }
}
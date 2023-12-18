public class RoleConfiguration
{
    public int RoleConfigID { get; set; }
    public int RoleID { get; set; }
    public bool CanAccessPublicPages { get; set; }
    public bool CanAccessSecretPages { get; set; }
    public bool CanAccessTopSecretPages { get; set; }
}

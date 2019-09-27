namespace eDrago.Enums
{
    public enum LogonSessionType : uint
    {
        Interactive = 2,  //Esta tiene permisos sobre los recursos de red
        Network, //Esta No tiene permisos sobre los recursos de red (curioso no?)
        Batch,
        Service,
        NetworkCleartext = 8,
        NewCredentials
    }

    public enum LogonProvider : uint
    {
        Default = 0, // default (usar esta)
        WinNT35,     // usa una señales dummy para autenticar (sends smoke signals to authority)
        WinNT40,     // usa NTLM
        WinNT50      // usa Kerberos o NTLM
    }
}

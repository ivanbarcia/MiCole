using System.ComponentModel;

namespace eDrago.Enums
{
    public enum States
    {
        [Description("Creado")]
        Created = 1,
        [Description("Modificado")]
        Modified = 2,
        [Description("Borrado")]
        Deleted = 3,
        [Description("Cancelado")]
        Cancellation = 4,
        [Description("Inactivo")]
        Inactive = 5,
        [Description("Pendiente de Autorizar")]
        PendingChanges = 9
    };


}

using EstudioColmenaTrabajoPractico.Modelo;

namespace EstudioColmenaTrabajoPractico.Controlador
{
    public class ModelodeUsuario
    {
        ObjAccDatos usuario = new ObjAccDatos();

        ////Attributes
        //private int idusuario;
        //private string usuario;
        //private string contraseña;
        //private string nombre;
        //private string apellido;
        //private string posicion;
        //private string email;
        ////Constructors
        //public ModelodeUsuario(int idusuario, string usuario, string contraseña, string nombre, string apellido, string posicion, string email)
        //{
        //    this.idusuario = idusuario;
        //    this.usuario = usuario;
        //    this.contraseña = contraseña;
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.posicion = posicion;
        //    this.email = email;
        //}
        //public ModelodeUsuario()
        //{
        //}
        ////Methods
        //public string editUserProfile()
        //{
        //    try
        //    {
        //        LoginMetodos.editProfile(idusuario, usuario, contraseña, nombre, apellido, email);
        //        LoginUser(usuario, contraseña);
        //        return "Tú perfil ha sido actualizado satisfactoriamente";
        //    }
        //    catch (Exception ex)
        //    {
        //        return "El nombre de usuario ya está registrado, intente con otro";
        //    }
        //}


        public bool LoginUser(string Usuario, string Contraseña)
        {
            return usuario.LoginDeUsuario(Usuario, Contraseña);
        }

        public void AnyMethod()
        {
            //Seguridad y Permisos
            if (Login.NivelAcceso == Posicion.Administrador)
            {
                //Codes
            }
            if (Login.NivelAcceso == Posicion.Arquitecto /*|| UserCache.Position == Positions.Compras || UserCache.Position == Positions.Arquitecto*/)
            {
                //Codes
            }
        }


        //CODIGOS PARA COLOCAR PERMISOS Y SEGURIDAD

        //public bool PermisosDeUsuarios(string usuario, string Contraseña)
        //{


        //}

        ObjAccDatos n = new ObjAccDatos();
        public string RecuperarContraseña(string userRequesting)
        {
            return n.RecuperarContraseña(userRequesting);
        }

        //public void AnyMethod()
        //{
        //    //Seguridad y Permisos
        //    if (Login.NivelAcceso == Posicion.Administrador)
        //    {
        //        //Codes
        //    }
        //    if (Login.NivelAcceso == Posicion.Arquitecto
        //        /*|| UserCache.Position == Positions.Compras || UserCache.Position == Positions.Arquitecto*/)
        //    {
        //        //Codes
        //    }
    }
}



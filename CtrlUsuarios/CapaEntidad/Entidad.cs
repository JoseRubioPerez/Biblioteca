namespace CapaEntidad
{
    public class Entidad
    {
        #region ENTIDADES_Administrador

        private string AdminNC;
        private string AdminNombre;
        private string AdminApellidoPaterno;
        private string AdminApellidoMaterno;
        private char AdminSexo;
        private string AdminPassword;
        //private Image AdminImagen;
        private char AdminSuperSu;

        public string getAdminNC()
        {
            return this.AdminNC;
        }

        public void setAdminNC(string AdminNC)
        {
            this.AdminNC = AdminNC;
        }

        public string getAdminNombre()
        {
            return this.AdminNombre;
        }

        public void setAdminNombre(string AdminNombre)
        {
            this.AdminNombre = AdminNombre;
        }

        public string getAdminApellidoPaterno()
        {
            return this.AdminApellidoPaterno;
        }

        public void setAdminApellidoPaterno(string AdminApellidoPaterno)
        {
            this.AdminApellidoPaterno = AdminApellidoPaterno;
        }

        public string getAdminApellidoMaterno()
        {
            return this.AdminApellidoMaterno;
        }

        public void setAdminApellidoMaterno(string AdminApellidoMaterno)
        {
            this.AdminApellidoMaterno = AdminApellidoMaterno;
        }

        public char getAdminSexo()
        {
            return this.AdminSexo;
        }

        public void setAdminSexo(char AdminSexo)
        {
            this.AdminSexo = AdminSexo;
        }

        public string getAdminPassword()
        {
            return this.AdminPassword;
        }

        public void setAdminPassword(string AdminPassword)
        {
            this.AdminPassword = AdminPassword;
        }

        /*public string getAdminImagen() { return this.AdminImagen; }
        public void setAdminImagen(string AdminImagen) { this.AdminImagen = AdminImagen; }*/

        public char getAdminSuperSu()
        {
            return this.AdminSuperSu;
        }

        public void setAdminSuperSu(char AdminSuperSu)
        {
            this.AdminSuperSu = AdminSuperSu;
        }

        #endregion ENTIDADES_Administrador

        #region ENTIDADES_Usuarios

        private string UsuarioNC;
        private string UsuarioNombre;

        public string getUsuarioNC()
        {
            return this.UsuarioNC;
        }

        public void setUsuarioNC(string UsuarioNC)
        {
            this.UsuarioNC = UsuarioNC;
        }

        public string getUsuarioNombre()
        {
            return this.UsuarioNombre;
        }

        public void setUsuarioNombre(string UsuarioNombre)
        {
            this.UsuarioNombre = UsuarioNombre;
        }

        #endregion ENTIDADES_Usuarios
    }
}
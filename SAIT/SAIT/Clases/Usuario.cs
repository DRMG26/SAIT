using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SAIT.Clases
{
    public class Usuario
    {
        int _intIdUsuario;
        string _strUsuario;
        string _strClave;
        string _strNombre;
        string _strApellido;
        //string _strCodusu;
        Boolean _blSuperUsuario;
        Boolean _blIndicadorActivo;

        public int IdUsuario
        {
            get { return _intIdUsuario; }
            set { _intIdUsuario = value; }
        }

        public string Login
        {
            get { return _strUsuario; }
            set { _strUsuario = value; }
        }

        public string Clave
        {
            get { return _strClave; }
            set { _strClave = value; }

        }

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public string Apellido
        {
            get { return _strApellido; }
            set { _strApellido = value; }
        }

        public Boolean SuperUsuario
        {
            get { return _blSuperUsuario; }
            set { _blSuperUsuario = value; }
        }

        public Boolean IndicadorActivo
        {
            get { return _blIndicadorActivo; }
            set { _blIndicadorActivo = value; }
        }

        public Usuario(int IdUsuario, string Login, string Clave, string Nombre, string Apellido, Boolean SuperUsuario, Boolean IndicadorActivo)
        {
            this._intIdUsuario = IdUsuario;
            this._strUsuario = Login;
            this._strClave = Clave;
            this._strNombre = Nombre;
            this._strApellido = Apellido;
            this._blSuperUsuario = SuperUsuario;
            this._blIndicadorActivo = IndicadorActivo;
        }

        public Usuario() : this(0, "", "", "", "", false, false)
        {
        }
    }
}
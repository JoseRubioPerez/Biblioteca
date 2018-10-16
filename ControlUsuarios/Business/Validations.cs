using System;
using System.Collections.Generic;
using System.Data;
using Connections;
using Options;
using Entity;

namespace Business
{
    public class Validations
    {
        private Queries ObjQueries = new Queries();
        private List<object> ValueForms = new List<object>();

        private void CatchExceptions(Exception Error, TypeModules Identificador)
        {
            ValueForms.Clear();
            ValueForms.Add(Error.InnerException); //Tipo de Error
            ValueForms.Add(Error.Message); //Mensaje de la excepción
            ValueForms.Add(Error.Source); //Origen del error
            ValueForms.Add(Error.TargetSite); //Método que generó la excepción
            ValueForms.Add(DateTime.Now.ToShortDateString()); //Fecha
            ValueForms.Add(DateTime.Now.ToLongTimeString()); //Hora
            ObjQueries.Procedimiento("Errors", ValueForms);
        } //Clave de Método: Validations-CE

        public DataTable LogSession(TypeModules Identificador, string NumControl, string Password)
        {
            ValueForms.Clear();
            try
            {
                if (NumControl.Length.Equals(8))
                {
                    if (string.IsNullOrEmpty(NumControl) || ReferenceEquals(1, int.Parse(NumControl)) || string.IsNullOrEmpty(Password))
                        throw new Exception();
                }
                else
                {
                    if (string.IsNullOrEmpty(NumControl) || ReferenceEquals(1, int.Parse(NumControl.Substring(1, (NumControl.Length - 1)))))
                        throw new Exception();
                }
                ValueForms.Add(NumControl); ValueForms.Add(Password);
                return ObjQueries.Procedimiento(nameof(LogSession), ValueForms);
            }
            catch (Exception Error) //Faltará crear una tabla para craer la bitácora de errores.
            {
                CatchExceptions(Error, Identificador);
                return null;
            }
        } //Clave de Método: Validations-LG

        public DataTable GridSearchMethod(TypeModules Identificador, TypeSearch Option)
        {
            ValueForms.Clear();
            try
            {
                string StoredProcedure = "";
                if (Option.Equals(0))
                    throw new Exception();
                switch (Option)
                {
                    case TypeSearch.Users:
                        {
                            StoredProcedure = "LoadUsers";
                            break;
                        }
                    case TypeSearch.Admin:
                        {
                            StoredProcedure = "LoadAdmins";
                            break;
                        }
                    case TypeSearch.Moves:
                        {
                            StoredProcedure = "LoadMoves";
                            break;
                        }
                    case TypeSearch.Areas:

                        {
                            StoredProcedure = "LoadAreas";
                            break;
                        }
                    default:
                        throw new Exception();
                }
                return ObjQueries.Procedimiento(StoredProcedure, ValueForms);
            }catch(Exception Error)
            {
                CatchExceptions(Error, Identificador);
                return null;
            }
        } //Clave de Método: Validations-GSM

        public DataTable ComboSearchMethod(TypeModules Identificador, TypeSearch Option)
        {
            ValueForms.Clear();
            try
            {
                if (Option.Equals(0))
                    throw new Exception();
                ValueForms.Add(Option);
                return ObjQueries.Procedimiento("LoadFilters", ValueForms);
            }
            catch (Exception Error)
            {
                CatchExceptions(Error, Identificador);
                return null;
            }
        } //Clave de Método: Validations-CSM

        public DataTable ExistUsuario(TypeModules Identificador, string NumControl)
        {
            ValueForms.Clear();
            try
            {
                if (string.IsNullOrEmpty(NumControl) || ReferenceEquals(1, int.Parse(NumControl)))
                    throw new Exception();
                ValueForms.Add(NumControl);
                return ObjQueries.Procedimiento("ExistUser", ValueForms);
            }
            catch(Exception Error)
            {
                CatchExceptions(Error, Identificador);
                return null;
            }
        } //Clave de Método: Validations-EU

        public bool PopUpUsersValidations(ModifyUsers ObjModifyUsersSource, ModifyUsers ObjModifyUsers)
        {
            return (ObjModifyUsersSource.NumControl != ObjModifyUsers.NumControl && ObjModifyUsersSource.FirstName != ObjModifyUsers.FirstName && ObjModifyUsersSource.SecondName != ObjModifyUsers.SecondName && ObjModifyUsersSource.FirstLastName != ObjModifyUsers.FirstLastName && ObjModifyUsersSource.SecondLastName != ObjModifyUsers.SecondLastName && ObjModifyUsersSource.Department != ObjModifyUsers.Department && ObjModifyUsersSource.Sex != ObjModifyUsers.Sex && ObjModifyUsersSource.Status != ObjModifyUsers.Status) ? false : true;
        }
    }
}
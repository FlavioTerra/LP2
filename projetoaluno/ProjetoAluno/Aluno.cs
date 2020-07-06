using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoAluno
{
    class Aluno
    {
        private int raaluno;
        private string nomealuno;
        private int cidadealuno;

        public int raAluno
        {
            get
            {
                return raAluno;
            }
            set
            {
                raAluno = value;
            }
        }

        public string nomeAluno
        {
            get
            {
                return nomeAluno;
            }
            set
            {
                nomeAluno = value;
            }
        }

        public int cidadeAluno
        {
            get
            {
                return cidadeAluno;
            }
            set
            {
                cidadeAluno = value;
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daAluno;

            DataTable dtAluno = new DataTable();

            try
            {
                daAluno = new SqlDataAdapter("SELECT * FROM TBALUNO", frmPrincipal.conexao);
                daAluno.Fill(dtAluno);
                daAluno.FillSchema(dtAluno, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAluno;
        }

        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO TBCIDADE VALUES (@ra_aluno,@nome_aluno,@cidade_id_aluno)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@ra_aluno", SqlDbType.Int));

                mycommand.Parameters.Add(new SqlParameter("@nome_aluno", SqlDbType.VarChar));

                mycommand.Parameters.Add(new SqlParameter("@cidade_id_aluno", SqlDbType.Int));

                mycommand.Parameters["@ra_aluno"].Value = raaluno;

                mycommand.Parameters["@nome_aluno"].Value = nomealuno;

                mycommand.Parameters["@cidade_id_aluno"].Value = cidadealuno;

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg = 0;

                mycommand = new SqlCommand("UPDATE TBALUNO SET ra_aluno = @ra_aluno , nome_aluno = @nome_aluno , cidade_id_aluno = @cidade_id_aluno WHERE ra_aluno = @ra_aluno", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@ra_aluno", SqlDbType.Int));

                mycommand.Parameters.Add(new SqlParameter("@nome_aluno", SqlDbType.VarChar));

                mycommand.Parameters.Add(new SqlParameter("@cidade_id_aluno", SqlDbType.Int));

                mycommand.Parameters["@ra_aluno"].Value = raaluno;

                mycommand.Parameters["@nome_aluno"].Value = nomealuno;

                mycommand.Parameters["@cidade_id_aluno"].Value = cidadealuno;

                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Excluir()
        {
            int nReg = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELTE FROM TBALUNO WHERE ra_aluno = @ra_aluno", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@ra_aluno", SqlDbType.Int));

                mycommand.Parameters["@ra_aluno"].Value = Convert.ToInt16(raaluno);

                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nReg;
        }

    }
}

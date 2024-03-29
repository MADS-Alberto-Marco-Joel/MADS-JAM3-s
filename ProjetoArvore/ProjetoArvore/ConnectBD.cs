﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArvore
{
    public class ConnectBD
    {
        public ConnectBD()
        {

        }
        public DataTable GetNomes(DataTable dt)
        {
            //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Database=Database1;Integrated Security=True";
            //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            string connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            string query = "Select * from Especies";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
        public DataTable GetArvoreByID(int id)
        {
            DataTable dt = new DataTable();

            return dt;
        }
        public DataTable GetArvoresToEdit(DataTable dt)
        {
            //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Database=Database1;Integrated Security=True";
            //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            string connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            string query = "Select arvore.id as Id,Especies.nomecientifico as NomeCientifico,altura,perimetro,diametro,validFrom,localizacao,COALESCE(NULLIF(Construcao.tipoconstrucao,''), 'Sem caldeira') as Caldeira from arvore" +
                " INNER JOIN Especies ON Especies.Id = arvore.NomeCientifico" +
                " LEFT JOIN Construcao ON Construcao.Id = arvore.idConstrucao" +
                " Where arvore.ativa = 0";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
       
        public DataTable GetCaldeiras(DataTable dt)
        {
            //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Database=Database1;Integrated Security=True";
            //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            string connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            string query = "Select * from Construcao";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
        public string InserirArvore(Arvore a)
        {
            string connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;            // <== lacking
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into arvore (NomeCientifico,altura,diametro,perimetro,validFrom,idConstrucao,localizacao,classificacao,ativa)" +
                    "VALUES (@es,@al,@di,@pe,@val,@IdC,@loc,0,0)";
                cmd.Parameters.AddWithValue("@es", a.NomeCientifico);
                cmd.Parameters.AddWithValue("@al", a.Altura);
                cmd.Parameters.AddWithValue("@di", a.Diametro);
                cmd.Parameters.AddWithValue("@pe", a.Perimetro);
                DateTime dateTime= DateTime.Parse(a.ValidFrom.ToShortDateString());
                cmd.Parameters.AddWithValue("@val",dateTime);
                
                if(a.IdConstrucao!=-1)
                    cmd.Parameters.AddWithValue("@IdC", a.IdConstrucao);
                else
                    cmd.Parameters.AddWithValue("@IdC", 0);


                cmd.Parameters.AddWithValue("@loc", a.Localizacao);




                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return "Inserida com sucesso";
                }
                catch (Exception ex)
                {
                    return "Erro ao inserir,verifique os campos e tente novamente \n" + ex.ToString();
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        public string InserirObservacao(Observacao a)
        {
            string connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;            // <== lacking
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Observacoes (idarvore,DataObs,inclinacao_do_tronco,codominancia_tronco,codominancia_ramos,casca_inclusa_tronco,casca_inclusa_ramos,fendas_tronco,fendas_cicatrizes_ramos,torcao_tronco,podridao_colo,podridao_ramos,cavidades_colo,cavidades_tronco,cavidades_ramos,estruturas_fungos_colo,estruturas_fungo_tronco,estruturas_fungo_ramos,exsudacao_colo,exsudacao_tronco ,exsudacao_ramos ,madeira_morta_ramos,cancros_tronco ,cancros_ramos,rebentos_ladroes,pragas_tronco,pragas_ramos) " +
                    "VALUES (@id,@data,@inclinacao_do_tronco,@codominancia_tronco,@codominancia_ramos," +
                    "@casca_inclusa_tronco,@casca_inclusa_ramos,@fendas_tronco,@fendas_cicatrizes_ramos," +
                    "@torcao_tronco,@podridao_colo,@podridao_ramos,@cavidades_colo,@cavidades_tronco," +
                    "@cavidades_ramos,@estruturas_fungos_colo,@estruturas_fungo_tronco,@estruturas_fungo_ramos," +
                    "@exsudacao_colo,@exsudacao_tronco,@exsudacao_ramos ,@madeira_morta_ramos,@cancros_tronco," +
                    "@cancros_ramos,@rebentos_ladroes,@pragas_tronco,@pragas_ramos)";
                cmd.Parameters.AddWithValue("@id", a.IDArvore);
                DateTime dateTime = DateTime.Parse(a.Data.ToShortDateString());
                cmd.Parameters.AddWithValue("@data", dateTime);
                cmd.Parameters.AddWithValue("@inclinacao_do_tronco", a.InclTronco);
                cmd.Parameters.AddWithValue("@codominancia_tronco", a.CodoTronco);
                cmd.Parameters.AddWithValue("@codominancia_ramos", a.CodoRamos);
                cmd.Parameters.AddWithValue("@casca_inclusa_tronco", a.CascTronco);
                cmd.Parameters.AddWithValue("@casca_inclusa_ramos", a.CascRamos);
                cmd.Parameters.AddWithValue("@fendas_tronco", a.CicatrizesTronco);
                cmd.Parameters.AddWithValue("@fendas_cicatrizes_ramos", a.CicatrizesRamos);
                cmd.Parameters.AddWithValue("@torcao_tronco", a.TorcaoTronco);
                cmd.Parameters.AddWithValue("@podridao_colo", a.PodridaoColo);
                cmd.Parameters.AddWithValue("@podridao_ramos", a.PodridaoRamos);
                cmd.Parameters.AddWithValue("@cavidades_colo", a.CavidadesColo);
                cmd.Parameters.AddWithValue("@cavidades_tronco", a.CavidadesTronco);
                cmd.Parameters.AddWithValue("@cavidades_ramos", a.CavidadesRamos);
                cmd.Parameters.AddWithValue("@estruturas_fungos_colo", a.FungoColo);
                cmd.Parameters.AddWithValue("@estruturas_fungo_tronco", a.FungoTronco);
                cmd.Parameters.AddWithValue("@estruturas_fungo_ramos", a.FungoRamos);
                cmd.Parameters.AddWithValue("@exsudacao_colo", a.ExsudacaoColo);
                cmd.Parameters.AddWithValue("@exsudacao_tronco", a.ExsudacaoTronco);
                cmd.Parameters.AddWithValue("@exsudacao_ramos", a.ExsudacaoRamos);
                cmd.Parameters.AddWithValue("@madeira_morta_ramos", a.MadeiraMorta);
                cmd.Parameters.AddWithValue("@cancros_tronco", a.CancroTronco);
                cmd.Parameters.AddWithValue("@cancros_ramos", a.CancroRamos);
                cmd.Parameters.AddWithValue("@rebentos_ladroes", a.Epicormicos);
                cmd.Parameters.AddWithValue("@pragas_tronco", a.PragasTronco);
                cmd.Parameters.AddWithValue("@pragas_ramos", a.PragasRamos);
                
                

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return "Inserida com sucesso";
                }
                catch (Exception ex)
                {
                    return "Erro ao inserir,verifique os campos e tente novamente \n" + ex.ToString();
                }
                finally
                {
                    conn.Close();
                }

            }
        }
        public string EditarArvore(Arvore a)
        {
            string connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;            // <== lacking
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update arvore SET altura=@al,diametro=@di,perimetro=@pe,validFrom=@val,idConstrucao=@IdC,localizacao=@loc " +
                    "WHERE NomeCientifico=@es";
                    
                cmd.Parameters.AddWithValue("@es", a.NomeCientifico);
                cmd.Parameters.AddWithValue("@al", a.Altura);
                cmd.Parameters.AddWithValue("@di", a.Diametro);
                cmd.Parameters.AddWithValue("@pe", a.Perimetro);
                DateTime dateTime = DateTime.Parse(a.ValidFrom.ToShortDateString());
                cmd.Parameters.AddWithValue("@val", dateTime);

                if (a.IdConstrucao != -1)
                    cmd.Parameters.AddWithValue("@IdC", a.IdConstrucao);
                else
                    cmd.Parameters.AddWithValue("@IdC", 0);


                cmd.Parameters.AddWithValue("@loc", a.Localizacao);




                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return "Inserida com sucesso";
                }
                catch (Exception ex)
                {
                    return "Erro ao inserir,verifique os campos e tente novamente \n" + ex.ToString();
                }
                finally
                {
                    conn.Close();
                }

            }
        }
    }
}

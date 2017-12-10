﻿using Resolucoes.Controleler;
using Resolucoes.Dao;
using Resolucoes.Model;
using Resolucoes.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resolucoes
{
    public partial class FrmPrincipal : Form
    {
        //AO CARREGAR O FORM, VERIFICA CONFIGS(VERSAO), MENSAGENS E DEPOIS CHAMA O METODO STATUS INICIAL
        public FrmPrincipal()
        {
            InitializeComponent();
            
            var s = new SistemasController();

            var configs = s.VerificaConfiguracoes();

            /*
            if (configs == null)//Se não conseguir ler as configurações do banco, fecha o sistema
            {
                Environment.Exit(0);

            }
            else if (configs.Versao == "")//Se o campo versão estiver em branco, fecha o sistema
            {
                Environment.Exit(0);
            }
            else if (configs.Versao != _versao)
            {
                MessageBox.Show("ATENÇÃO !!!\nEsta versão está desatualizada, por favor, baixe a nova versão" +
                    "\nno link: " + configs.linkNovaVersao + "", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            if (configs.Menssagem.Length > 0)//Se tiver alguma mensagem, exibe na inicialização
            {
                MessageBox.Show(configs.Menssagem);
            }
            */
            StatusInicial();
        }
        //ATENÇÃO !!!
        //VERSAO DO SISTEMA
        //AO GERAR UMA NOVA VERSAO ALTERAR ESSA CONSTANTE
        public const string _versao = "1.0.1";

        //BOTÃO OK
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (textSistema.Text.Length < 1)
                {
                    MessageBox.Show("Escolha um sistema !");
                }
                else
                {
                    int op = 0;
                    op = Convert.ToInt32(textSistema.Text);
                    switch (op)
                    {
                        case 1:
                            lblSistema.Text = "TOTVSCHEF";
                            break;
                        case 2:
                            lblSistema.Text = "CHEF WEB";
                            break;
                        case 3:
                            lblSistema.Text = "TEF";
                            break;
                        default:
                            lblSistema.Text = ".";
                            MessageBox.Show("Opção inválida !");
                            textSistema.Text = "";
                            break;
                    }

                    if (lblSistema.Text.Length > 2)
                    {
                        textSistema.Enabled = false;

                        btnOk.Enabled = true;
                        btnNovo.Enabled = true;
                        btnGravar.Enabled = false;
                        btnCancelar.Enabled = true;
                        btnBuscarRegistro.Enabled = true;
                        btnBuscarAssunto.Enabled = true;

                        textRegistro.Enabled = true;
                        textAssunto.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor inválido !");
                textSistema.Text = "";
            }
        }

        //BOTÃO CANCELAR, CHAMANDO O METODO STATUS INICIAL
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            StatusInicial();
        }

        //BOTÃO NOVO
        private void btnNovo_Click(object sender, EventArgs e)
        {
            textRegistro.Enabled = false;
            textAssunto.Enabled = true;
            textRegistro.Enabled = false;
            textDescricao.Enabled = true;

            textDataGravacao.Text = Convert.ToString(System.DateTime.Now);
            textRegistro.Text = "0";
            textAssunto.Text = "";
            textDescricao.Text = "";

            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnBuscarRegistro.Enabled = false;
            btnBuscarAssunto.Enabled = false;

        }

        //BOTÃO GRAVAR
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Sistemas m = new Sistemas();
            int tabela = Convert.ToInt32(textSistema.Text);
            m.Codigo = Convert.ToInt32(textRegistro.Text);
            m.Assunto = textAssunto.Text;
            m.Descricao = textDescricao.Text;
            m.DataUltimaGravacao = System.DateTime.Now;

            m.QuemGravou = Environment.UserName;

            SistemasController mController = new SistemasController();
            if (mController.Gravar(m, tabela) == 1)//Se o retorno 1 então foi inserido novo registro
            {
                MessageBox.Show("Gravação concluida !\nRegistro: " + mController.UltimoRegistro(tabela));
                StatusInicial();
            }
            else if (mController.Gravar(m, tabela) == 2)//Se o retorno 2 então foi atualizado
            {
                MessageBox.Show("Gravação concluida !");
                StatusInicial();
            }

        }

        //CAPTURANDO A TECLA ENTER NO TEXTBOX SISTEMA
        private void textSistema_KeyDown(object sender, KeyEventArgs e)
        {
            var k = e.KeyCode;

            if (k.ToString() == "Return")
            {
                btnOk.PerformClick();
            }

        }

        //CHAMANDO O EVENTO DO BOTÃO OK
        private void textSistema_KeyDown_1(object sender, KeyEventArgs e)
        {
            var k = e.KeyCode;

            if (k.ToString() == "Return")
            {
                btnOk.PerformClick();
            }
        }

        //ACEITA APENAS NÚMEROS NO TEXTBOX SISTEMA
        private void textSistema1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //BLOQUEIA DIGITAR NO CAMPO ASSUNTO SE O BOTÃO GRAVAR NÃO ESIVER HABILITADO
        private void textAssunto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (btnGravar.Enabled == false)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        //BUSCAR REGISTRO
        private void btnBuscarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                SistemasController sController = new SistemasController();

                Sistemas s = sController.BuscaCodigo(Convert.ToInt32(textRegistro.Text), Convert.ToInt32(textSistema.Text));
                if (s == null)
                {
                    textRegistro.Text = "";
                }

                textDescricao.Text = "";

                textRegistro.Text = Convert.ToString(s.Codigo);
                textAssunto.Text = s.Assunto;
                textDescricao.Text = s.Descricao;
                textDataGravacao.Text = Convert.ToString(s.DataUltimaGravacao);

                textAssunto.Enabled = true;
                textDescricao.Enabled = false;//Desabilitado e habilitado no final, pois o texto estava vindo todo selecionado

                btnNovo.Enabled = true;
                btnGravar.Enabled = true;
                btnCancelar.Enabled = true;
                btnBuscarRegistro.Enabled = false;
                btnBuscarAssunto.Enabled = false;

                textRegistro.Enabled = false;
                textDescricao.Enabled = true;

            }
            catch (Exception)
            {

            }

        }

        //ACEITA APENAS NÚMEROS NO TEXTBOX REGISTRO
        private void textRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //BUSCAR ASSUNTO
        private void btnBuscarAssunto_Click(object sender, EventArgs e)
        {
            SistemasController sController = new SistemasController();

            var lista = new List<Sistemas>();
            lista = sController.BuscarAssunto(textAssunto.Text, Convert.ToInt32(textSistema.Text));


            if (lista.Count == 0)
            {
                textDescricao.Enabled = true;
                textDescricao.Enabled = true;
                MessageBox.Show("Não encontrado !");
            }
            else if (lista.Count == 1)
            {
                textRegistro.Text = Convert.ToString(lista[0].Codigo);
                textAssunto.Text = lista[0].Assunto;
                textDescricao.Text = lista[0].Descricao;
                textDataGravacao.Text = Convert.ToString(lista[0].DataUltimaGravacao);

                textRegistro.Enabled = false;
                textDescricao.Enabled = false;//Desabilitado e habilitado no final, pois o texto estava vindo todo selecionado

                btnGravar.Enabled = true;
                btnBuscarRegistro.Enabled = false;
                btnBuscarAssunto.Enabled = false;

                textDescricao.Enabled = true;
            }
            else
            {
                var sb = new System.Text.StringBuilder();
                for (int i = 0; i < lista.Count; i++)
                {
                    sb.AppendLine("REGISTRO: " + Convert.ToString(lista[i].Codigo));
                    sb.AppendLine("ASSUNTO: " + lista[i].Assunto);
                    sb.AppendLine("-------------------------------------------------------" +
                        "--------------------------------------------------------------------" +
                        "------------------------------------------------------------");
                }
                textDescricao.Text = sb.ToString();
                textDescricao.Enabled = true;
            }
        }

        //METODO ESTATUS INICIAL
        public void StatusInicial()
        {
            textSistema.SelectionStart = 0;
            textSistema.Focus();
            textSistema.Select();
            textSistema.Text = "";
            lblSistema.Text = "";
            textRegistro.Text = "";
            textAssunto.Text = "";
            textDescricao.Text = "";
            textDataGravacao.Text = "";

            textDataGravacao.Enabled = false;
            textSistema.Enabled = true;
            textRegistro.Enabled = false;
            textAssunto.Enabled = false;

            textDescricao.Enabled = false;

            btnOk.Enabled = true;
            btnNovo.Enabled = false;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnBuscarRegistro.Enabled = false;
            btnBuscarAssunto.Enabled = false;

        }
    }
}

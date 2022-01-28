using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infocurso.Model.Entities
{
    public class Utils : Form
    {
        public void mascaraTelefone(TextBox telefone, ref int letrasTelefone)
        {
            string txtTelefone = telefone.Text;

            //Verifica se o usuário está apagando ou inserindo caractere.
            //Caso esteja inserindo, adicionará a máscara em conjunto com a insersão
            if (letrasTelefone < txtTelefone.Length)
            {
                //O primeiro dígito vem acompanhado de: (
                if (telefone.TextLength == 1)
                {
                    txtTelefone = "(" + telefone.Text.Substring(0, 1);
                    telefone.Text = "";
                    telefone.AppendText(txtTelefone);
                }

                //O terceiro dígito fecha os dois primeiros: (##) #
                if (telefone.TextLength == 4)
                {
                    txtTelefone = telefone.Text.Substring(0, 3) + ") " + telefone.Text.Substring(3, 1);
                    telefone.Text = "";
                    telefone.AppendText(txtTelefone);
                }

                //O sétimo dígito inclui um - antes de ser inserido: (##) ####-#
                if (telefone.TextLength == 10)
                {
                    txtTelefone = telefone.Text.Substring(0, 9) + "-" + txtTelefone.Substring(9, 1);
                    telefone.Text = "";
                    telefone.AppendText(txtTelefone);
                }

                //Se o telefone for celular, ou seja, tiver 11 dígitos, ele substituirá a posição do hífen entre o sexto e o sétimo para entre o sétimo
                //e o outavo: (##) # ####-####
                if (telefone.TextLength == 15)
                {
                    txtTelefone = txtTelefone.Replace("-", "");
                    txtTelefone = txtTelefone.Substring(0, 6) + " " + txtTelefone.Substring(6, 4) + "-" + txtTelefone.Substring(10);
                    telefone.Text = txtTelefone;
                    telefone.Select(Right, telefone.TextLength);
                }
                //Informará o novo tamanho da máscara para o telefeone.
                letrasTelefone = txtTelefone.Length;
            }
            //Caso o usuário esteja apagando, esta ação ocorrerá
            else
            {
                //Se a máscara for de 11 dígitos para 10, ele incluirá novamente a máscara de telefone fixo: (##) ####-####
                if (telefone.TextLength == 15)
                {
                    txtTelefone = txtTelefone.Replace("-", "").Replace(" ", "");
                    txtTelefone = txtTelefone.Substring(0, 4) + " " + txtTelefone.Substring(4, 4) + "-" + txtTelefone.Substring(8);
                    telefone.Text = txtTelefone;
                    telefone.Select(Right, telefone.TextLength);
                }
                //Se a máscara estiver em 7 dígitos, além de apagar o número, ele apagará também o hífen: (##) ####
                if (telefone.TextLength == 10)
                {
                    txtTelefone = telefone.Text.Substring(0, 9);
                    telefone.Text = "";
                    telefone.AppendText(txtTelefone);
                }
                //Se a máscara estiver em 3 dígitos, ele apagará o ultimo dígito junto com o ") ": (##
                if (telefone.TextLength == 5)
                {
                    txtTelefone = telefone.Text.Substring(0, 3);
                    telefone.Text = "";
                    telefone.AppendText(txtTelefone);
                }
                //Se a máscara conter apenas 1 dígito, ele apagará este dígito e o "(" anterior, zeando o campo de texto.
                if (telefone.TextLength == 1)
                {
                    txtTelefone = telefone.Text.Substring(0, 0);
                    telefone.Text = "";
                    telefone.AppendText(txtTelefone);
                }
                //Informa para o programa o novo tamanho da máscara.
                letrasTelefone = txtTelefone.Length;
            }
        }
        public void mascaraCpf(TextBox cpf, ref int numCpf)
        {
            string txtCpf = cpf.Text;

            //Verifica se o usuário está apagando ou inserindo caractere.
            //Caso esteja inserindo, adicionará a máscara em conjunto com a insersão
            if (numCpf < txtCpf.Length)
            {
                //O terceiro dígito vem acompanhado de ".": ###.#
                if (cpf.TextLength == 4)
                {
                    txtCpf = cpf.Text.Substring(0, 3) + "." + cpf.Text.Substring(3,1);
                    cpf.Text = "";
                    cpf.AppendText(txtCpf);
                }

                //O sexto dígito vem acompanhado de ".": ###.###.#
                if (cpf.TextLength == 8)
                {
                    txtCpf = cpf.Text.Substring(0, 7) + "." + cpf.Text.Substring(7, 1);
                    cpf.Text = "";
                    cpf.AppendText(txtCpf);
                }

                //O décimo dígito inclui um - antes de ser inserido: ###.###.###-##
                if (cpf.TextLength == 12)
                {
                    txtCpf = cpf.Text.Substring(0, 11) + "-" + txtCpf.Substring(11, 1);
                    cpf.Text = "";
                    cpf.AppendText(txtCpf);
                }
                //Informará o novo tamanho da máscara para o cpf.
                numCpf = txtCpf.Length;
            }
            //Caso o usuário esteja apagando, esta ação ocorrerá
            else
            {
                //Se a máscara estiver em 7 dígitos, além de apagar o número, ele apagará também o hífen: (##) ####
                if (cpf.TextLength == 12)
                {
                    txtCpf = cpf.Text.Substring(0, 11);
                    cpf.Text = "";
                    cpf.AppendText(txtCpf);
                }
                //Se a máscara estiver em 3 dígitos, ele apagará o ultimo dígito junto com o ") ": (##
                if (cpf.TextLength == 8)
                {
                    txtCpf = cpf.Text.Substring(0, 7);
                    cpf.Text = "";
                    cpf.AppendText(txtCpf);
                }
                //Se a máscara conter apenas 1 dígito, ele apagará este dígito e o "(" anterior, zeando o campo de texto.
                if (cpf.TextLength == 4)
                {
                    txtCpf = cpf.Text.Substring(0, 3);
                    cpf.Text = "";
                    cpf.AppendText(txtCpf);
                }
                //Informa para o programa o novo tamanho da máscara.
                numCpf = txtCpf.Length;
            }
        }
        public void mascaraRg(TextBox rg, ref int numRg)
        {
            string txtRg = rg.Text;

            //Verifica se o usuário está apagando ou inserindo caractere.
            //Caso esteja inserindo, adicionará a máscara em conjunto com a insersão
            if (numRg < txtRg.Length)
            {
                //O terceiro dígito vem acompanhado de ".": #.#
                if (rg.TextLength == 2)
                {
                    txtRg = rg.Text.Substring(0, 1) + "." + rg.Text.Substring(1, 1);
                    rg.Text = "";
                    rg.AppendText(txtRg);
                }

                //O sexto dígito vem acompanhado de ".": #.###.#
                if (rg.TextLength == 6)
                {
                    txtRg = rg.Text.Substring(0, 5) + "." + rg.Text.Substring(5, 1);
                    rg.Text = "";
                    rg.AppendText(txtRg);
                }
                //Informará o novo tamanho da máscara para o rg.
                numRg = txtRg.Length;
            }
            //Caso o usuário esteja apagando, esta ação ocorrerá
            else
            {
                //Se a máscara estiver em 4 dígitos, além de apagar o número, ele apagará também o ponto: #.###
                if (rg.TextLength == 6)
                {
                    txtRg = rg.Text.Substring(0, 5);
                    rg.Text = "";
                    rg.AppendText(txtRg);
                }
                //Se a máscara estiver em 1 dígito, ele apagará o ultimo dígito junto com o ponto: #
                if (rg.TextLength == 2)
                {
                    txtRg = rg.Text.Substring(0, 1);
                    rg.Text = "";
                    rg.AppendText(txtRg);
                }
                //Informa para o programa o novo tamanho da máscara.
                numRg = txtRg.Length;
            }
        }
    }
}

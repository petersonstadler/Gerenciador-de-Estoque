using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Estoque.VIEW
{
    class Validador
    {
        public bool ValidarCampoNome(string txt)
        {
            if (txt.Length < 3)
            {
                return false;
            }
            return true;
        }

        public bool ValidarCampoPreco(string txt)
        {
            if (float.TryParse(txt, out float a))
            {
                if (a < 0)
                {
                    return false;
                }
            }
            if (txt == "" || txt == null || txt.Length < 1 || txt.Length > 12)
            {
                return false;
            }
            else
            {
                if (!EhNumero(txt))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool EhNumero(string txt)
        {
            if (int.TryParse(txt, out int vi))
            {
                return true;
            }
            if (float.TryParse(txt, out float vf))
            {
                return true;
            }
            if (double.TryParse(txt, out double vdou))
            {
                return true;
            }
            if (decimal.TryParse(txt, out decimal vdec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TemVirgula(string txt)
        {
            if (txt.Contains(','))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CampoFloat(string campo, char key) //Verifica se o campo é float, e permite a adição de apenas umas virgula (Usado para eventos KeyPress).
        {
            if (key == ',' && TemVirgula(campo))
            {
                return true;
            }
            if (!EhNumero(Convert.ToString(key)) && key != ',' && key != 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

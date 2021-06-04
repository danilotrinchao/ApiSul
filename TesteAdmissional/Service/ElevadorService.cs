using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TesteAdmissional.Contexto;
using TesteAdmissional.Interface;
using TesteAdmissional.Models;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace TesteAdmissional.Service
{
    public class ElevadorService : IElevadorService
    {

        static Elevador pElevadorObj ;
        List<Elevador> pElevador = JsonSerializer.Deserialize<List<Elevador>>(File.ReadAllText("../../../input.json"));

        public List<int> andarMenosUtilizado()
        {
            List<int> lAndares = new List<int>();
            int lAndaresMenosUtilizados = 0;
            for (int i = 0; i <= pElevador.Count; i++)
                if (lAndaresMenosUtilizados <= pElevador.Count(x => x.andar == i) ) 
                {
                    //lAndaresMenosUtilizados = pElevador[i] == i ? pElevador : -1
                    //Count(x => x.andar == i)                    
                    lAndaresMenosUtilizados = pElevador.Count(x => x.andar == i);                 
                    lAndares.Add(lAndaresMenosUtilizados);
                    
                        //lAndares.Add(lAndaresMenosUtilizados);
                }
                    

            //for (int i = 0; i < pElevador.Count - 1; i++)
              //  if (lAndaresMenosUtilizados == pElevador.Count(x => x.andar == i) )
                 //   lAndares.Add(lAndaresMenosUtilizados);
            
            return lAndares;

        }

        public List<char> elevadorMaisFrequentado()
        {
            List<char> lListaElevador = new List<char>();

            int lElevadorA = pElevador.Count(x => x.elevador == 'A'),
                lElevadorB = pElevador.Count(x => x.elevador == 'B'),
                lElevadorC = pElevador.Count(x => x.elevador == 'C'),
                lElevadorD = pElevador.Count(x => x.elevador == 'D'),
                lElevadorE = pElevador.Count(x => x.elevador == 'E'),
                lElevadorMaisUtilizado = 0;

                lElevadorMaisUtilizado = lElevadorA;
                if (lElevadorMaisUtilizado < lElevadorB)
                    lElevadorMaisUtilizado = lElevadorB;
                if (lElevadorMaisUtilizado < lElevadorC)
                    lElevadorMaisUtilizado = lElevadorC;
                if (lElevadorMaisUtilizado < lElevadorD)
                    lElevadorMaisUtilizado = lElevadorD;
                if (lElevadorMaisUtilizado < lElevadorE)
                    lElevadorMaisUtilizado = lElevadorE;


            if (lElevadorMaisUtilizado == lElevadorA)
                lListaElevador.Add('A');
            if (lElevadorMaisUtilizado == lElevadorB)
                lListaElevador.Add('B');
            if (lElevadorMaisUtilizado == lElevadorC)
                lListaElevador.Add('C');
            if (lElevadorMaisUtilizado == lElevadorD)
                lListaElevador.Add('D');
            if (lElevadorMaisUtilizado == lElevadorE)
                lListaElevador.Add('E');

            return lListaElevador;
        }

        public List<char> elevadorMenosFrequentado()
        {
            List<char> lListaElevador = new List<char>();

            int lElevadorA = pElevador.Count(x => x.elevador == 'A'),
                lElevadorB = pElevador.Count(x => x.elevador == 'B'),
                lElevadorC = pElevador.Count(x => x.elevador == 'C'),
                lElevadorD = pElevador.Count(x => x.elevador == 'D'),
                lElevadorE = pElevador.Count(x => x.elevador == 'E'),
                lElevadorMenosUtilizado = 0;

            lElevadorMenosUtilizado = lElevadorA;
            if (lElevadorMenosUtilizado > lElevadorB)
                lElevadorMenosUtilizado = lElevadorB;
            if (lElevadorMenosUtilizado > lElevadorC)
                lElevadorMenosUtilizado = lElevadorC;
            if (lElevadorMenosUtilizado > lElevadorD)
                lElevadorMenosUtilizado = lElevadorD;
            if (lElevadorMenosUtilizado > lElevadorE)
                lElevadorMenosUtilizado = lElevadorE;


            if (lElevadorMenosUtilizado == lElevadorA)
                lListaElevador.Add('A');   
            if (lElevadorMenosUtilizado == lElevadorB)
                lListaElevador.Add('B');   
            if (lElevadorMenosUtilizado == lElevadorC)
                lListaElevador.Add('C');   
            if (lElevadorMenosUtilizado == lElevadorD)
                lListaElevador.Add('D');   
            if (lElevadorMenosUtilizado == lElevadorE)
                lListaElevador.Add('E');

            return lListaElevador;
        }

        public float percentualDeUsoElevadorA()
        {
            return (float)(pElevador.Count(x => x.elevador == 'A') * 100.0 / pElevador.Count / 100.0);
        }

        public float percentualDeUsoElevadorB()
        {
            return (float)(pElevador.Count(x => x.elevador == 'B') * 100.0 / pElevador.Count / 100.0);
        }

        public float percentualDeUsoElevadorC()
        {
            return (float)(pElevador.Count(x => x.elevador == 'C') * 100.0 / pElevador.Count / 100.0);
        }

        public float percentualDeUsoElevadorD()
        {
            return (float)(pElevador.Count(x => x.elevador == 'D') * 100.0 / pElevador.Count / 100.0);
        }

        public float percentualDeUsoElevadorE()
        {
            return (float)(pElevador.Count(x => x.elevador == 'E') * 100.0 / pElevador.Count / 100.0);
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            List<char> lListaElevador = new List<char>();
            List<char> elevadores = new List<char>();
            if (pElevadorObj == null)
                elevadores = elevadorMaisFrequentado();
            else
                elevadores.Add(pElevadorObj.elevador);

            foreach (var elevador in elevadores)
            {
                int lFluxoMatutino = pElevador.Count(x => x.elevador == elevador && x.turno == 'M'),
                    lFluxoVespertino = pElevador.Count(x => x.elevador == elevador && x.turno == 'V'),
                    lFluxoNoturno = pElevador.Count(x => x.elevador == elevador && x.turno == 'N'),
                    lFluxoMaiorUtilizacao = 0;

                lFluxoMaiorUtilizacao = lFluxoMatutino;
                if (lFluxoMaiorUtilizacao < lFluxoVespertino)
                    lFluxoMaiorUtilizacao = lFluxoVespertino;
                if (lFluxoMaiorUtilizacao < lFluxoNoturno)
                    lFluxoMaiorUtilizacao = lFluxoNoturno;

                if (lFluxoMaiorUtilizacao == lFluxoMatutino)
                    lListaElevador.Add('M');              
                if (lFluxoMaiorUtilizacao == lFluxoVespertino)
                    lListaElevador.Add('V');              
                if (lFluxoMaiorUtilizacao == lFluxoNoturno)
                    lListaElevador.Add('N');

            }

            pElevadorObj = null;
            return lListaElevador;
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {

            List<char> lListaElevador = new List<char>();
            int lFluxoMatutino = pElevador.Count(x => x.turno == 'M'),
                lFluxoVespertino = pElevador.Count(x => x.turno == 'V'),
                lFluxoNoturno = pElevador.Count(x => x.turno == 'N'),
                lFluxoMaiorUtilizacao = 0;

            lFluxoMaiorUtilizacao = lFluxoMatutino;
            if (lFluxoMaiorUtilizacao < lFluxoVespertino)
                lFluxoMaiorUtilizacao = lFluxoVespertino;
            if (lFluxoMaiorUtilizacao < lFluxoNoturno)
                lFluxoMaiorUtilizacao = lFluxoNoturno;

            if (lFluxoMaiorUtilizacao == lFluxoMatutino)
                lListaElevador.Add('M');
            if (lFluxoMaiorUtilizacao == lFluxoVespertino)
                lListaElevador.Add('V');
            if (lFluxoMaiorUtilizacao == lFluxoNoturno)
                lListaElevador.Add('N');

            return lListaElevador;
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            List<char> lListaElevador = new List<char>();
            List<char> elevadores = new List<char>();
            if (pElevadorObj == null)
                elevadores = elevadorMenosFrequentado();
            else
                elevadores.Add(pElevadorObj.elevador);

            foreach (var elevador in elevadores)
            {
                int lFluxoMatutino = pElevador.Count(x => x.elevador == elevador && x.turno == 'M'),
                    lfluxoVespertino = pElevador.Count(x => x.elevador == elevador && x.turno == 'V'),
                    lfluxoNoturno = pElevador.Count(x => x.elevador == elevador && x.turno == 'N'),
                    lfluxoMenorUtilizacao = 0;

                lfluxoMenorUtilizacao = lFluxoMatutino;
                if (lfluxoMenorUtilizacao > lfluxoVespertino)
                    lfluxoMenorUtilizacao = lfluxoVespertino;
                if (lfluxoMenorUtilizacao > lfluxoNoturno)
                    lfluxoMenorUtilizacao = lfluxoNoturno;

                if (lfluxoMenorUtilizacao == lFluxoMatutino)
                    lListaElevador.Add('M');
                if (lfluxoMenorUtilizacao == lfluxoVespertino)
                    lListaElevador.Add('V');
                if (lfluxoMenorUtilizacao == lfluxoNoturno)
                    lListaElevador.Add('N');

            }

            pElevadorObj = null;
            return lListaElevador;
        }
    }
}

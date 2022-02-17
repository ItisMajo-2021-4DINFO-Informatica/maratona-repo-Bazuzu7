using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FrancoProvaComune5
{
    class Maratone
    {
        public List<Maratona> elencoMaratone;


        public Maratone()
        {
            elencoMaratone = new List<Maratona>();
        }

        public void Aggiungi(Maratona maratona)
        {
            elencoMaratone.Add(maratona);
        }

        public void LeggiDati()
        {
            using (FileStream flussoDati = new FileStream("maratona.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader lettoreDati = new StreamReader(flussoDati))
                {
                    while (!lettoreDati.EndOfStream)
                    {
                        string linea = lettoreDati.ReadLine();
                        string[] campi = linea.Split('%');

                        Maratona maratona = new Maratona();
                        maratona.nomeAtleta = campi[0];
                        maratona.societàDiAppartenenza = campi[1];
                        maratona.tempoImpiegato = campi[2];
                        maratona.cittàMaratona = campi[3];

                        Aggiungi(maratona);



                    }
                }
            }
        }

        public int CalcolaTempoMinuti(string nomeCittà, string nomeAtleta) 
        {
            string tempo = "";
            int ore = 0;
            int minuti = 0;
            foreach (var maratona in elencoMaratone)
            {
                if (maratona.nomeAtleta == nomeAtleta && maratona.cittàMaratona == nomeCittà)
                {
                    tempo = maratona.tempoImpiegato;
                }
            }

            ore = int.Parse(tempo.Substring(0,1));
            minuti = int.Parse(tempo.Substring(2, 2));


            return (ore * 60) + minuti;
        }



        public string CercaAtletaPerCittà(string titolo)
        {
            string artista = titolo + "--NON TROVATO--";

            foreach (var brano in elencoBrani)
            {
                if (brano.TitoloBrano == titolo)
                {
                    artista = brano.NomeArtista;
                }
            }

            return artista;
        }


    }
}

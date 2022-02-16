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
    }
}

   

                

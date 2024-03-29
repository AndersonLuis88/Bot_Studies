﻿using Newtonsoft.Json;
using System;
using System.Net;

namespace Bot_MegaSena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do concurso:");
            string numeroConcurso = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(numeroConcurso))
            {
                numeroConcurso = "2103";
            }

            string url = @"http://loterias.caixa.gov.br/wps/portal/loterias/landing/megasena/!ut/p/a1/04_Sj9CPykssy0xPLMnMz0vMAfGjzOLNDH0MPAzcDbwMPI0sDBxNXAOMwrzCjA0sjIEKIoEKnN0dPUzMfQwMDEwsjAw8XZw8XMwtfQ0MPM2I02-AAzgaENIfrh-FqsQ9wNnUwNHfxcnSwBgIDUyhCvA5EawAjxsKckMjDDI9FQE-F4ca/dl5/d5/L2dBISEvZ0FBIS9nQSEh/pw/Z7_HGK818G0KO6H80AU71KG7J0072/res/id=buscaResultado/c=cacheLevelPage/=/?timestampAjax=1559842971218&concurso="+ numeroConcurso;
            string json;
            using (WebClient wc = new WebClient())
            {
                wc.Headers["Cookie"] = "security=true";
                json = wc.DownloadString(url);
            }
            Resultado resultadoMega = JsonConvert.DeserializeObject<Resultado>(json);
            
            Console.WriteLine("--------Resultado do Concurso--------");
            Console.WriteLine();
            Console.WriteLine("        --------" +numeroConcurso+ "--------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("          "+ resultadoMega.resultadoOrdenado);


            Console.ReadKey()
;         }
    }
}

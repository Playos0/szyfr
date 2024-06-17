namespace szyfr
{
    public class Szyfr
    {
        public static void Main(string[] args)
        {
            szyfrowanie();
        }

        public static void szyfrowanie()
        {
            string tekst = Console.ReadLine();
            string szyfr = "GADERYPOLUKI";
            string tekst_szyfr = String.Empty;
            for (int i = 0; i< tekst.Length; i++)
            {
                for (int j = 0; j < szyfr.Length; j++)
                {
                    if (tekst[i] == szyfr[j])
                    {
                        if(j % 2 == 0)
                        {
                            tekst_szyfr += szyfr[j + 1];

                        }
                        else
                        {
                            tekst_szyfr += szyfr[j - 1];
                        }
                    }

                }
                if(tekst_szyfr.Length-i == 0)
                {
                    tekst_szyfr += tekst[i];

                }
                
            }
            Console.Write(tekst_szyfr);

        }
    }
}
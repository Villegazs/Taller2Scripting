namespace DelegadoScripting
{
    internal class Program
    {
        public delegate void Tecla(string s);


        public static void TeclaW(string s)
        {
            Console.WriteLine(s + " W");
        }

        public static void TeclaA(string s)
        {
            Console.WriteLine(s + " A");
        }

        public static void TeclaS(string s)
        {
            Console.WriteLine(s + " S");
        }

        public static void TeclaD(string s)
        {
            Console.WriteLine(s + " D");
        }

        public static void TeclaF(string s)
        {
            Console.WriteLine(s + " F");
        }



        static void Main(string[] args)
        {
            Tecla delegado;
            delegado = TeclaW;
            delegado += TeclaA;
            delegado += TeclaS;
            delegado += TeclaD;
            delegado += TeclaF;

            delegado.Invoke("Se oprimio la tecla:");


        }
    }
}

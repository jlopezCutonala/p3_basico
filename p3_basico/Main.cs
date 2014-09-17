using System;

namespace basico
{
    class Principal
    {
        private const double piValor = 3.1416;
        private readonly string nombre = "Juan Pérez";

        public Principal(){
            this.nombre = "Juan Hernandez";
        }

        public void PI(){
            Console.WriteLine( "El valor de pi es " + piValor );
        }

        public void imprimeNombre(){
            Console.WriteLine( "Su nombre es " + this.nombre );
        }

        public void Xor()
        {
            // Cuando un operador es verdadero y el otro es false, OR-exclusivo
            // regresa true.
            Console.WriteLine(true ^ false);
            // Cuando ambos operadores son falsos
            // regresa false
            Console.WriteLine(false ^ false);
            // Cuando ambos operadores son true
            // regresa false
            Console.WriteLine(true ^ true);
        }

        public static void Main (string[] args)
        {
            // Este comentario ejemplifica como escribir comentarios abreviados de una sola línea
           	Principal principal = new Principal();
            principal.PI();
            Console.WriteLine ("");
            principal.imprimeNombre();
            principal.Xor();
            /* Esto es un comentario
                que ejemplifica cómo se escribe comentarios que ocupen varias líneas */

        }
    }
}

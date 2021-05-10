using System;

namespace Horoscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            DateTime fechaNacimiento;
            Random r = new Random();
            String[] signosNombres = {"Acuario", "Piscis", "Aries", "Tauro", "Géminis", "Cáncer", "Leo", "Virgo", "Libra", "Escorpio", "Sagitario", "Capricornio"};
            int[] diasZodiacales = {21, 20, 21, 21, 22, 22, 24, 24, 24, 24, 23, 23};
            int[] mesesZodiacales = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            String[] frasesAmor = {"Día de revelaciones y decisiones importantes.",
                "La jornada se presentará tensa en la pareja.",
                "Procura mantener la serenidad y no hacer aquello que podría empeorar la situación.",
                "Buscarás el apoyo de tu pareja o de amigos para afrontar situaciones difíciles.",
                "Tus inseguridades saldrán a relucir cuando personas del pasado de tu pareja vuelvan repentinamente a tu vida.",
                "Luego de un día agitado buscarás refugiarte en los brazos de tu pareja, para librarte de las tensiones de tu ambiente laboral."
            };
            String[] frasesDinero = {"Perderás la paciencia con tus subordinados el día de hoy.",
                "No podrás soportar más ciertas actitudes por parte de tu superior y decidirás tomar cartas en el asunto.",
                "Finalmente dejarás de lado aquel proyecto con el que has insistido tanto tiempo y ninguna ganancia te ha dejado.",
                "Comenzarás la semana con muy buenas noticias en tu ámbito laboral.",
                "Ciertas cuestiones pendientes se desvanecen sin problemas.",
                "Se acerca la conclusión de tu proyecto más importante, pero vivirás horas de tensión y nerviosismo hasta que lo entregues."
            };
            String[] frasesBienestar = {"No permitas que el negativismo afecte tus sentidos y evite que veas las salidas.",
                "No dejes pasar un día de tu existencia sin sacarle algo positivo.",
                "No permitas que todo el trabajo que tienes invertido en proyectos personales se pierda simplemente porque alcanzar tus metas se ha hecho difícil.",
                "Debes aprender de tus errores y continuar adelante.",
                "No subestimes la influencia que el karma puede llegar a tener en tu vida.",
                "Debes aprender a ser menos severo con los errores de las personas que te rodean."
            };

            Console.WriteLine("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su fecha de nacimiento: (YYYY-MM-DD)");
            fechaNacimiento = DateTime.Parse(Console.ReadLine());

            int a, b, d;
            a = r.Next(0, 5);
            d = r.Next(0, 5);
            b = r.Next(0, 5);

         
            int dn, mn, signo;
            
            dn = fechaNacimiento.Day;
            mn = fechaNacimiento.Month;

            signo = mn - 2;
            if (diasZodiacales[signo] < dn)
            {
                signo += 1;
            };

            Console.WriteLine("Hola {0} tu signo es {1}", nombre, signosNombres[signo]);
            Console.WriteLine("Salud: {0} \nDinero: {1}\nBienestar: {2}", frasesAmor[a], frasesBienestar[b], frasesDinero[0]);
        }
    }
}

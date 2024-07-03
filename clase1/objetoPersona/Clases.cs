namespace libreriaClase{

    class Persona
    {

//        private string nombre;


        public string Apellido {get;set;}

        public string Nombre {get;set;}

        public string DNI {get;set;}
        
        public string FechaNacimiento {get;set;}
        

       

        public  Persona(string rApellio,string rNombre, string rFechaNacimiento, string rDni){
            Apellido = rApellio;
            Nombre = rNombre;
            FechaNacimiento = rFechaNacimiento;
            DNI= rDni;

        }

        public Persona(){
            
        }
        public string caminar(){

            return "Caminando....";

        }

        public void mostrarPersona(){
            Console.WriteLine("Apellido: {0}", Apellido);
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Fecha Nacimiento: {0}", FechaNacimiento);
            Console.WriteLine("DNI: {0}", DNI);
        }

        public void devolverEdad(){
            Console.WriteLine("La edad es:.....");
        }

    }


    class Alumno : Persona {

        private int legajo;
        private string curso;

        private int[] notas;


        public void estudiar(){
            Console.WriteLine("Estudiando....");
        }

        public void devolverCurso(){
            Console.WriteLine("El curso es: {0}", this.curso);
        }
    }

}
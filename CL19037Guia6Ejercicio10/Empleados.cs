using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL19037Guia6Ejercicio10
{
    class Empleados
    {
        //Atributos
        string nombre, newNombre, apellido, newApellido, genero, newGenero;
        double salario, newSalario, salarioB;
        int edad, newEdad, contador;
        
        //Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
        public string NewNombre
        {
            get
            {
                return newNombre;
            }

            set
            {
                newNombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }
        public string NewApellido
        {
            get
            {
                return newApellido;
            }

            set
            {
                newApellido = value;
            }
        }
        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }
        public string NewGenero
        {
            get
            {
                return newGenero;
            }

            set
            {
                newGenero = value;
            }
        }
        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }
        public double NewSalario
        {
            get
            {
                return newSalario;
            }

            set
            {
                newSalario = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }
        public int NewEdad
        {
            get
            {
                return newEdad;
            }

            set
            {
                newEdad = value;
            }
        }
        public int Contador
        {
            get
            {
                return contador;
            }

            set
            {
                contador = value;
            }
        }
        public double SalarioB
        {
            get
            {
                return salarioB;
            }

            set
            {
                salarioB = value;
            }
        }

        //Metodos
        //Metodo para evaluar el nombre, edad y genero, (general), de la persona con mayor salario y a la vez su salario
        public string NameMaG()
        {
            string name = null;
            if (contador == 0)
            {
                name = newNombre + " " + NewApellido;
            }
            if (contador != 0)
            {
                if (newSalario >= salario)
                {
                    name = newNombre + " " + NewApellido;
                }
                else if (salario > newSalario)
                {
                    name = nombre;
                }
            }
            return name;
        }
        public int AgeMaG()
        {
            int age = 0;
            if (contador == 0)
            {
                age = newEdad;
            }
            if (contador != 0)
            {
                if (newSalario >= salario)
                {
                    age = newEdad;
                }
                else if (salario > newSalario)
                {
                    age = edad;
                }
            }
            return age;
        }
        public string GenderMaG()
        {
            string gender = null;
            if (contador == 0)
            {
                gender = newGenero;
            }
            if (contador != 0)
            {
                if (newSalario >= salario)
                {
                    gender = newGenero;
                }
                else if (salario > newSalario)
                {
                    gender = genero;
                }
            }
            return gender;
        }
        public double SalarioMaG()
        {
            double sala = 0;
            if (contador == 0)
            {
                sala = newSalario;
            }
            if (contador != 0)
            {
                if (newSalario >= salario)
                {
                    sala = newSalario;
                }
                else if (salario > newSalario)
                {
                    sala = salario;
                }
            }
            return sala;
        }

        //Metodo para evaluar el nombre, edad y genero, de la persona femenina con mayor salario y a la vez su salario
        public string NameM()
        {
            string name = null;
            if (contador == 0)
            {
                name = newNombre + " " + NewApellido;
            }
            if (contador != 0)
            {
                if (newSalario >= salario)
                {
                    name = newNombre + " " + NewApellido;
                }
                else if (salario > newSalario)
                {
                    name = nombre;
                }
            }
            return name;
        }
        public int AgeM()
        {
            int age = 0;
            if (contador == 0)
            {
                age = newEdad;
            }
            if (contador != 0)
            {
                if (newSalario >= salario)
                {
                    age = newEdad;
                }
                else if (salario > newSalario)
                {
                    age = edad;
                }
            }
            return age;
        }
        public string GenderM()
        {
            string gender = null;
            if (contador == 0)
            {
                gender = newGenero;
            }
            if (contador != 0)
            {
                if (newSalario >= salario)
                {
                    gender = newGenero;
                }
                else if (salario > newSalario)
                {
                    gender = genero;
                }
            }
            return gender;
        }
        public double SalarioM()
        {
            double sala = 0;
            if (contador == 0)
            {
                sala = newSalario;
            }
            if (contador != 0)
            {
                if (newSalario >= salario)
                {
                    sala = newSalario;
                }
                else if (salario > newSalario)
                {
                    sala = salario;
                }
            }
            return sala;
        }

        //Metodo para evaluar el nombre, edad y genero, de la persona masculina con mayor salario y a la vez su salario
        public string NameH()
        {
            string name = null;
            if (contador == 0)
            {
                name = newNombre + " " + NewApellido;
            }
            if (contador != 0)
            {
                if (newSalario >= salario)
                {
                    name = newNombre + " " + NewApellido;
                }
                else if (salario > newSalario)
                {
                    name = nombre;
                }
            }
            return name;
        }
        public int AgeH()
        {
            int age = 0;
            if (contador == 0)
            {
                age = newEdad;
            }
            if (contador != 0)
            {
                if (newSalario >= salario)
                {
                    age = newEdad;
                }
                else if (salario > newSalario)
                {
                    age = edad;
                }
            }
            return age;
        }
        public string GenderH()
        {
            string gender = null;
            if (contador == 0)
            {
                gender = newGenero;
            }
            if (contador != 0)
            {
                if (newSalario >= salario)
                {
                    gender = newGenero;
                }
                else if (salario > newSalario)
                {
                    gender = genero;
                }
            }
            return gender;
        }
        public double SalarioH()
        {
            double sala = 0;
            if (contador == 0)
            {
                sala = newSalario;
            }
            if (contador != 0)
            {
                if (newSalario >= salario)
                {
                    sala = newSalario;
                }
                else if (salario > newSalario)
                {
                    sala = salario;
                }
            }
            return sala;
        }

        //Metodo para evaluar el nombre, edad y genero, (general), de la persona con menor salario y a la vez su salario y un bono
        public string NameMeG()
        {
            string name = null;
            if (contador == 0)
            {
                name = newNombre + " " + NewApellido;
            }
            if (contador != 0)
            {
                if (newSalario <= salario)
                {
                    name = newNombre + " " + NewApellido;
                }
                else if (salario < newSalario)
                {
                    name = nombre;
                }
            }
            return name;
        }
        public int AgeMeG()
        {
            int age = 0;
            if (contador == 0)
            {
                age = newEdad;
            }
            if (contador != 0)
            {
                if (newSalario <= salario)
                {
                    age = newEdad;
                }
                else if (salario < newSalario)
                {
                    age = edad;
                }
            }
            return age;
        }
        public string GenderMeG()
        {
            string gender = null;
            if (contador == 0)
            {
                gender = newGenero;
            }
            if (contador != 0)
            {
                if (newSalario <= salario)
                {
                    gender = newGenero;
                }
                else if (salario < newSalario)
                {
                    gender = genero;
                }
            }
            return gender;
        }
        public double SalarioMeG()
        {
            double sala = 0;
            if (contador == 0)
            {
                sala = newSalario;
            }
            if (contador != 0)
            {
                if (newSalario <= salario)
                {
                    sala = newSalario;
                }
                else if (salario < newSalario)
                {
                    sala = salario;
                }
            }
            return sala;
        }
        public double Bono()
        {
            double bono;
            bono = salarioB * (1.10);
            return bono;
        }
    }
}

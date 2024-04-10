# Taller #2 Scripting

### 2. Explicar por medio de un ejemplo de mínimo 5 funciones el concepto de delegado

~~~
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

~~~
### 3. Consultar y crear un ejemplo donde se evidencie el uso de event en C# (Comparar el modelo de eventos definido en Corgi)
-   Un <b>evento</b> es una notificación enviada por un objeto para señalar la ocurrencia de una acción.
- La clase que genera eventos se llama <b>Publicador</b> y la clase que recibe la notificación se llama <b>Suscriptor.</b> Puede haber varios suscriptores de un solo evento. Normalmente, un editor genera un evento cuando se produce alguna acción. Los suscriptores que estén interesados ​​en recibir una notificación cuando se produzca una acción deben registrarse en un evento y gestionarlo.

Para implementar un evento en **C#** Necesitamos:
- Definir un **delegado**
- Definir un **evento que depende de ese delegado**
- Plantear un **evento**

En C#, un evento es un <b>delegado encapsulado</b>. Depende del delegado. El delegado define la firma para el método del controlador de eventos de la clase de suscriptor.
### 4. Consultar qué es Singleton, sus pros y sus contras ¿Cómo se implementa solo en C#? y ¿Cómo se implementa en Unity? (Donde está presente en Corgi) 
<b>Singleton</b>
El patrón Singleton es un patrón de diseño que restringe la creación de instancias de una clase a un objeto y proporciona una forma de acceder a su objeto.
![enter image description here](https://dotnettutorials.net/wp-content/uploads/2018/06/Singleton-Design-Pattern-in-C.png?ezimgfmt=ng:webp/ngcb8)
Tomado de: https://dotnettutorials.net/lesson/singleton-design-pattern/

Diferentes clientes están intentando obtener la instancia singleton. Una vez que el cliente obtiene la instancia singleton, puede invocar los métodos usando la misma instancia.

#### Beneficios:
-   Puede estar seguro de que una clase tiene una sola instancia. 
- Obtienes un punto de acceso global a esa instancia. 
- El objeto singleton se inicializa sólo cuando se solicita por primera vez.

#### Contras:
- 
### 5. Investigar y explicar un patrón de POO y un principio
### 6. Consultar y explicar el ciclo de vida de un script en Unity
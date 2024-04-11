
# Taller #2 Scripting
--
## [Presentación](##%20Link%20de%20la%20presentaci%C3%B3n%20%20https://www.canva.com/design/DAGB-3HUoQM/k_u-osnr_MLoFGj7MPcZTg/edit?utm_content=DAGB-3HUoQM&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton)

### 2. Explicar por medio de un ejemplo de mínimo 5 funciones el concepto de delegado
---

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
---
-   Un <b>evento</b> es una notificación enviada por un objeto para señalar la ocurrencia de una acción.
- La clase que genera eventos se llama <b>Publicador</b> y la clase que recibe la notificación se llama <b>Suscriptor.</b> Puede haber varios suscriptores de un solo evento. Normalmente, un editor genera un evento cuando se produce alguna acción. Los suscriptores que estén interesados ​​en recibir una notificación cuando se produzca una acción deben registrarse en un evento y gestionarlo.

Para implementar un evento en <b>C#</b> Necesitamos:
- Definir un **delegado**
- Definir un **evento que depende de ese delegado**
- Plantear un **evento**

En C#, un evento es un <b>delegado encapsulado</b>. Depende del delegado. El delegado define la firma para el método del controlador de eventos de la clase de suscriptor.

#### Corgi Engine
---
##### Event Manager
![enter image description here](https://file.garden/ZduZHLwq23DtX9Mi/Scripting/EventManager.png)
##### Event Listener
![enter image description here](https://file.garden/ZduZHLwq23DtX9Mi/Scripting/MMeventListener.png)
##### Event Tester
![enter image description here](https://file.garden/ZduZHLwq23DtX9Mi/Scripting/Event%20Tester.png)
### 4. Consultar qué es Singleton, sus pros y sus contras ¿Cómo se implementa solo en C#? y ¿Cómo se implementa en Unity? (Donde está presente en Corgi) 
---
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
- Transmitir el estado entre las pruebas **puede dar lugar a pruebas que no sean independientes**, lo que dificulta aislar los problemas.
- Puede **generar dependencias ocultas entre clases**, lo que hace que el sistema sea más complejo y menos predecible.
- **Pueden limitar la escalabilidad y la flexibilidad.** A menudo se convierten en cuellos de botella a medida que la aplicación crece

### Corgi engine
---

#### Singleton
![enter image description here](https://file.garden/ZduZHLwq23DtX9Mi/Scripting/SIngletonCorgi.png)
![enter image description here](https://file.garden/ZduZHLwq23DtX9Mi/Scripting/SIngletonCorgi2.png)

#### Game Manager
![enter image description here](https://file.garden/ZduZHLwq23DtX9Mi/Scripting/GameManager.Corgi.png)
### 5. Investigar y explicar un patrón de POO y un principio
---
#### Patrón de diseño Observer
El patrón de diseño Observer permite observar los cambios producidos por un objeto, de esta forma, cada cambio que afecte el estado del objeto observado lanzará una notificación a los observadores; a esto se le conoce como Publicador-Suscriptor.
#### Principio SOLID
---
 1. S (**Single Responsibility Principle (SRP) o Principio de Responsabilidad Única**):  Cada clase debería tener una sola responsabilidad.
 2. O(**Open/Closed Principle (OCP) o Principio de Código Abierto/Cerrado**):No se debe cambiar el código existente, se debe agregar una nueva funcionalidad.
 3. L(**Liskov Substitution Principle (LSP) o Principio de Sustitución de Liskov**): Los objetos de las subclases deben poder ser reemplazables por objetos de sus clases superiores a lo largo del código.
 4. (**Interface Segregation Principle (ISP) o Principio de Segregación de Interfaz**): _«Una interfaz específica de cliente para cada tipo particular de clientes»._
 5. (**Dependency Inversion Principle (DIP) o Principio de Inversión de Dependencia**): _«Es mejor depender de interfaces o clases abstractas que depender de clases concretas»_

    
### 6. Consultar y explicar el ciclo de vida de un script en Unity

<b>Awake>OnEnable>Start>Update</b>

El ciclo de vida de un script en unity comienza por la inicialización del script que llama los métodos Awake(o start) y OnEnable, en el primero buscas inicializar objetos, asignar valores, inicializar componentes. Con OnEnable buscamos las conexiones con otros objetos.

A continuación toma lugar la ejecución de las físicas, pues se tras inicializar, que ocurre solo una vez por código, se ingresa en un loop llamado FixedUpdate

![alt text](image.png)

este ciclo puede ocurrir más de una vez por frame si no se limitan los tics del computador


# PreTest
Examen de ingreso Curso de Ingeniería de Software orientado a Videojuegos.

Parte F

¿Cómo se podría establecer a estos objetos como imprimibles?.

Propongo crear una interfaz "Imprimible" con un método "Imprimir" con el objetivo de que cualquier clase que la implemplente se encargue de comunicarse con el responsable de imprimir o en su defecto que devuelva un objeto que el responsable de impresión necesita.

Por lo tanto la clase Cotización deberia implementar la interfaz "Imprimible" y para el historial se debería crear una clase que contenga la lista de cotizaciones e implemente la interfaz "Imprimible".

Parte H

Por favor, especifica tu nombre completo: Juan Pablo Artola

¿C# permite herencia múltiple?  
No

¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
Cuando heredar propiedades o métodos implementados y requiera al menos un método abstracto.

¿Qué implica una relación de Generalización entre dos clases?
Implica herencia, quiere decir que una clase obtiene las propiedades y comportamientos que la super clase tiene. Si la super clase es abstracta, la sub clase debe resolverla o también será abstracta.

¿Qué implica una relación de Implementación entre una clase y una interfaz?
Implica que la clase relacionada esta obligada a implemntar los métodos definidos por la interfaz, o en su defecto, las subclases deberán hacerlo.

¿Qué diferencia hay entre la relación de Composición y la Agregación?
La diferencia principal es conceptual, ambas relaciones definen dependencia de una clase con otra, pero en una Agregación los objectos relacionados tienen cierto grado de independencia y su existencia no esta condicionada al la del otro. En cambio, en una Composición existe una relación dependiente de contenedor y componente, donde el componente tiene relevacia en el sistema si y solo si exite una relación con un contenedor.

Indique V o F según corresponda. Diferencia entre Asociación y Agregación:
Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual.   V
Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1.   F
Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación.   F

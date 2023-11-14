using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Program
    {
        // INTEGRANTES:
        // N00290160: ALA ALARCON PATRICK SAARICK
        // N00294797: AIQUIPA ARCE HAROLD ANTONY
        // N00237406: CASAVILCA QUIROZ FERNANDO JOSE
        // N00335591: VASQUEZ RODAS WILMER JOSHMAN
        // N00285078: VALVERDE YDOÑA DIEGO ALESSANDRO
        static void Main(string[] args)
        {
            ABBProvincias abbPeru = new ABBProvincias();

            //Datos de las provincias del Perú por población
            string[] provincias = {"Chachapoyas", "Bagua", "Bongara", "Condorcanqui", "Luya", "Rodríguez de Mendoza", "Utcubamba",
                 "Huaraz", "Aija", "Antonio Raimondi", "Asunción", "Bolognesi", "Carhuaz", "Carlos Fermín Fitzcarrald", "Casma",
                  "Corongo", "Huari", "Huarmey", "Huaylas", "Mariscal Luzuriaga", "Ocros", "Pallasca", "Pomabamba",
                  "Recuay", "Santa", "Sihuas", "Yungay", "Abancay", "Andahuaylas", "Antabamba", "Aymaraes", "Cotabambas",
                  "Chincheros", "Grau", "Arequipa", "Camaná", "Caravelí", "Castilla", "Caylloma", "Condesuyos", "Islay",
                  "La Unión", "Huamanga", "Cangallo", "Huanca Sancos", "Huanta", "La Mar", "Lucanas", "Parinacochas",
                  "Páucar del Sara Sara", "Sucre", "Víctor Fajardo", "Vilcashuamán", "Cajamarca", "Cajabamba", "Celendín", "Chota","Contumazá", "Cutervo", "Hualgayoc", "Jaén", "San Ignacio", "San Marcos", "San Miguel", "San Pablo", "Santa Cruz",
                  "Prov. Const. del Callao", "Cuzco", "Acomayo", "Anta", "Calca", "Canas", "Canchis", "Chumbivilcas", "Espinar",
                  "La Convención", "Paruro", "Paucartambo", "Quispicanchi", "Urubamba", "Huancavelica", "Acobamba", "Angaraes",
                  "Castrovirreyna", "Churcampa", "Huaytará", "Tayacaja", "Huánuco", "Ambo", "Dos de Mayo", "Huacaybamba", "Huamalíes",
                  "Leoncio Prado", "Marañón", "Pachitea", "Puerto Inca", "Lauricocha", "Yarowilca", "Ica", "Chincha", "Nazca",
                  "Palpa", "Pisco", "Huancayo", "Chanchamayo", "Chupaca", "Concepción", "Jauja", "Junín", "Satipo", "Tarma", "Yauli",
                  "Trujillo", "Ascope", "Bolívar", "Chepén", "Gran Chimú", "Julcán", "Otuzco", "Pacasmayo", "Pataz", "Sánchez Carrión",
                  "Santiago de Chuco", "Virú", "Chiclayo", "Ferreñafe", "Lambayeque", "Lima", "Huaura", "Barranca", "Cajatambo", "Canta",
                  "Cañete", "Huaral","Huarochirí", "Oyón", "Yauyos", "Maynas", "Alto Amazonas", "Datem del Marañón", "Loreto", "Mariscal Ramón Castilla",
                  "Putumayo", "Requena", "Ucayali", "Tambopata", "Manu", "Tahuamanu", "Mariscal Nieto", "General Sánchez Cerro", "Ilo",
                  "Pasco", "Daniel Alcides Carrión", "Oxapampa", "Piura", "Ayabaca", "Huancabamba", "Morropón", "Paita", "Sechura",
                  "Sullana", "Talara", "Puno", "Azángaro", "Carabaya", "Chucuito", "El Collao", "Huancané", "Lampa", "Melgar", "Moho",
                  "San Antonio de Putina", "San Román", "Sandia", "Yunguyo", "Moyobamba", "Bellavista", "El Dorado", "Huallaga", "Lamas",
                  "Mariscal Cáceres", "Picota", "Rioja", "San Martín", "Tocache", "Tacna", "Candarave", "Jorge Basadre", "Tarata",
                  "Tumbes", "Contralmirante Villar", "Zarumilla", "Coronel Portillo", "Atalaya", "Padre Abad", "Purús" };

            int[] poblaciones = { 55506, 74100, 25637, 42470, 44436, 29998, 107237, 163936, 6316, 13650, 7378, 23797, 45184, 17717, 50989, 7532, 58714, 30560, 51334, 20284, 7039, 23491, 24794,
                17185, 435807, 26971, 50841, 110520, 142477, 11310, 24307, 50656, 45247, 21242, 108635,
                59370, 41346, 33629, 86771, 16118, 52034, 12827, 282194, 30443, 8409, 89466, 70653, 51328,
                27659, 9609, 9445, 20109, 16861, 348433, 75687, 79084, 142984, 27693, 120723, 77944, 185432,
                130620, 48103, 46043, 21102, 37164, 994494, 447588, 22940, 56206, 63155, 32484, 95774, 66410,
                57582, 147148, 25567, 42504, 87430, 60739, 115054, 38208, 49207, 13982, 32538, 17247, 81403,
                293397, 50880, 33258, 16551, 52039, 127793, 26622,49159,32538,18913,19897,391519,226113,69157,13232,150744,545615,
                151489,52988,55591,83257,23133,203985,89590,40390,970016,115786,14457,78418,26892,28024,77862,102897,76103,144405,50896,92324,
                799675,97415,300170,8574974,227685,144381,6559,11548,240013,183898,58145,17739,20463,479866,122725,48482,62437,49072,
                7780,58511,54637,111474,18549,11047,85349,14865,74649,123015,43580,87470,799321,119287,111501,162027,129892,79177,311454,
                144150,219494,110392,73322,89002,63878,57651,40856,67138,19753,36113,307417,50742,36939,122365,
                55033,36752,27506,81521,64626,40545,122544,193095,69394,306363,6102,10773,6094,154962,21057,48844,384168,49324,60107,2860};

            // Crear el árbol y agregar las provincias
            for (int i = 0; i < provincias.Length; i++)
            {
                abbPeru.Insertar(provincias[i], poblaciones[i]);
            }

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine(" - - - - - - -");
                Console.WriteLine("1. Buscar provincia");
                Console.WriteLine("2. Eliminar provincia");
                Console.WriteLine("3. Mostrar provincias ordenadas por población");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Ingrese el nombre de la provincia a buscar: ");
                        string provinciaBuscada = Console.ReadLine();
                        Nodo nodoBuscado = abbPeru.BuscarProvincia(provinciaBuscada);

                        if (nodoBuscado != null)
                        {
                            Console.WriteLine("Encontrado");
                            Console.WriteLine($"{nodoBuscado.Provincia}: {nodoBuscado.Poblacion} Habitantes");
                        }
                        else
                        {
                            Console.WriteLine($"{provinciaBuscada} no encontrada.");
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Ingrese el nombre de la provincia a eliminar: ");
                        string provinciaEliminar = Console.ReadLine();
                        abbPeru.EliminarProvincia(provinciaEliminar);
                        Console.WriteLine("La provincia ha sido eliminada.");
                        break;

                    case "3":
                        Console.Clear();
                        // Imprimir las provincias ordenadas por población
                        abbPeru.ImprimirOrden(abbPeru.Raiz);
                        break;

                    case "4":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                        break;
                }
            }

            Console.ReadKey();
        }  
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Hotel.Models;

namespace Proyecto_Hotel.Controllers
{
    public class ClientesController : Controller
    {
        private readonly DbContextCliente _context;
        public ClientesController(DbContextCliente context)
        {
            _context= context;

        }



        //---------------------------------------------------------------------------------------------------------
        //                                  CREAR
        [HttpGet]

        //Metodo encargado para mostrar el front-end de crear cliente
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]


        //Metodo encargado de almacenar el cliente
        public async Task<IActionResult> Create([Bind] Cliente pCliente)
        {
            if (pCliente == null) //Si no tiene datos
            {
                return View(null); //Se ubica al usuario dentro del formulario
            }
            else //Si hay datos
            {
                pCliente.Cedula = 0; //Se calcula de forma automatica

                _context.clientes.Add(pCliente); //Se agrega el cliente
                await _context.SaveChangesAsync(); //Se guardan los cambios 
                return RedirectToAction("Index"); //Se ubica al usuario dentro de la lista de clientes
            } //Cierre del if
        } //Cierre del metodo create


        //---------------------------------------------------------------------------------------------------------
        //                                  DETAILS

        [HttpGet]

        public async Task<IActionResult> Details(int id)
        {
            //Se busca el cliente que vamos a mostrar los detalles por medio de la cedula
            var temp = await _context.clientes.FirstOrDefaultAsync(t => t.Cedula == id);
            //Retorna el front-end con los datos de los clientes
            return View(temp);
        }


        //---------------------------------------------------------------------------------------------------------
        //                                  DELETE

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            //Se busca el cliente que se desea eliminar por medio de la cedula
            var temp = await _context.clientes.FirstOrDefaultAsync(r => r.Cedula == id);

            //Se envia los datos del cliente a eliminar al front-end
            return View(temp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            //Se busca el cliente que se desea eliminar por medio de la cedula
            var temp = await _context?.clientes.FirstOrDefaultAsync(r => r.Cedula == id);

            if (temp == null) //Si no tiene datos
            {
                return View(null); //Se ubica al usuario dentro del formulario
            }
            else //Si tiene datos
            {
                //Se elimina el cliente
                _context.clientes.Remove(temp);

                //Se aplican los cambios en la base de datos
                await _context.SaveChangesAsync();

                //Se muestra el listado de clientes
                return RedirectToAction("Index");
            } //Cierre del if
        } //Cierre del metodo delete

        //---------------------------------------------------------------------------------------------------------


       

        [HttpPost]
        public async Task<IActionResult> Index()
        {

            var listado = await _context.clientes.ToListAsync();



            return View(listado);//se envia 
        }

        [HttpGet]

        public async Task<IActionResult> Edit(int id)
        {
            //se envia los datos 
            var temp = await _context.clientes.FirstOrDefaultAsync(t => t.Cedula == id);

            return View(temp);

        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, [Bind] Cliente pClientes)
        {
            if (id == pClientes.Cedula)
            {
                var temp = await _context.clientes.FirstOrDefaultAsync(r => r.Cedula == id);

                if (temp == null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    _context.clientes.Remove(temp);//se borra 
                    _context.clientes.Add(pClientes);//se agrega 
                    await _context.SaveChangesAsync();//se aplican cambios
                    return RedirectToAction("Index");//se muestra la lista
                }
            }
            else
            {
                return View();
            }
        }//fin del método



    }
}

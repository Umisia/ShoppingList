using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleShoppingList.Models;

namespace SimpleShoppingList.Controllers
{
    public class ShoppingListController : ApiController
    {
        //mock list
        public static List<ShoppingList> shoppingLists = new List<ShoppingList>
        {
            new ShoppingList() {Id = 0, Name = "groceries", Items = {
                    new Item {Id = 0,  Name = "raz" , ShoppingListId = 0},
                    new Item {Id = 1,  Name = "dwa", ShoppingListId = 0}
                }
            },
            new ShoppingList() {Id = 1, Name = "hardware"}
        };

        // GET: api/ShoppingList/5
        public IHttpActionResult Get(int id)
        {
            ShoppingList result = shoppingLists.FirstOrDefault(x => x.Id == id);

            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // POST: api/ShoppingList
        public IEnumerable Post([FromBody]ShoppingList newList)
        {
            newList.Id = shoppingLists.Count;
            shoppingLists.Add(newList);
            return shoppingLists;
        }

    }
}

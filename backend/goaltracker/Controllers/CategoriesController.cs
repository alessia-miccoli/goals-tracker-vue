using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using goaltracker.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace goaltracker.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private GoalTrackerDbContext _dbContext;

        public CategoriesController(GoalTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api/values
        [HttpGet]
        public Response Get()
        {
            return new Response(true, "Got Categories", _dbContext.Categories);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Response Get(int id)
        {
            var category = _dbContext.Categories.Find(id);

            return category==null?
                new Response(false, $"Category with id:{id} not found"):
                new Response(true, "Category found", category);
        }

        // POST api/values
        [HttpPost]
        public async Task<Response> Post([FromForm]string value)
        {
            try
            {
                var category = JsonConvert.DeserializeObject<Category>(value);
                var entry = _dbContext.Categories.Add(category);
                await _dbContext.SaveChangesAsync();
                return new Response(true, $"Category has been added to Db with id={entry.Entity.Id}");
            }
            catch(Exception e)
            {
                return  new  Response(false, e.Message);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<Response> Put(int id, [FromForm]string value)
        {
            try
            {
                var newCategory = JsonConvert.DeserializeObject<Category>(value);
                var oldCategory = await _dbContext.Categories.FindAsync(id);
                oldCategory.Name = newCategory.Name;
                oldCategory.Goals = newCategory.Goals;
                
                await _dbContext.SaveChangesAsync();
                return new Response(true, "Category updated", null);
            }
            catch(Exception e)
            {
                return new Response(false, e.Message);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<Response> Delete(int id)
        {
            try
            {
                _dbContext.Categories.Remove(await _dbContext.Categories.FindAsync(id));
                await _dbContext.SaveChangesAsync();
                return new Response(true, "Category deleted", null);
            }
            catch (Exception e)
            {
                return new Response(false, e.Message);
            }
        }
    }
}

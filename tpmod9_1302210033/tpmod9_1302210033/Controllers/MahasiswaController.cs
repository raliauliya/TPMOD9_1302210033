using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmod9_1302210033.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {

        private static List<Mahasiswa> mahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Putri Auliya Rahmah" , "1302210033"),
            new Mahasiswa("Hilman Fariz Hirzi" , "1302213092"),
            new Mahasiswa("Jaatsiyah Maulidina Astrianto" , "1302213043"),
            new Mahasiswa("Liyan Made Leon WAYAN" , "1302213037"),
            new Mahasiswa("Rihan Hidayat" , "1302210028")
        };

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswa[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa newMahasiswa)
        {
            mahasiswa.Add(newMahasiswa);
        }

        // PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswa.RemoveAt(id);
        }
    }
}

using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VideoLibrary.Api.Models;

namespace VideoLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/videos")]
    public class Videos : ControllerBase
    {
        private readonly VideoStore _videoStore;

        public Videos(VideoStore videoStore)
        {
            _videoStore = videoStore;
        }

        public IActionResult All() => Ok(_videoStore.All);

        public IActionResult Get(int id) => Ok(_videoStore.All.FirstOrDefault(x => x.Id == id));

        [HttpPost]
        public IActionResult Create([FromBody] Video video)
        {
            _videoStore.Add(video);
            return Ok();
        }
        
        [HttpPut]
        public IActionResult Update([FromBody] Video video)
        {
            throw  new NotImplementedException();
        }
        
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            throw  new NotImplementedException();
        }
        // [HttpPut]
        // public IActionResult Update([FromBody] Video video)
        // {
        //     throw  new NotImplementedException();
        // }
        //
        // [HttpDelete]
        // public IActionResult Delete(int id)
        // {
        //     throw  new NotImplementedException();
        // }
    }
}
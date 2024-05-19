using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIGMA.Models;
using SIGMA.Repository;

namespace SIGMA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        ICandidateInterface _candidateInterface;

        public CandidateController(ICandidateInterface service)
        {
            _candidateInterface = service;
        }

        /// <summary>
        /// save candidate
        /// </summary>
        /// <param name="candidateModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public ResponseModel SaveCandidates([FromBody]Candidate candidateModel)
        {
            try
            {
                var model = _candidateInterface.SaveCandidate(candidateModel);
                return model;
            }
            catch (Exception ex)
            {
                return new ResponseModel
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}

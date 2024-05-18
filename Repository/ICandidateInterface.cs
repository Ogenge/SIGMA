using SIGMA.Models;

namespace SIGMA.Repository
{
    public interface ICandidateInterface
    {
        /// <summary>
        /// get candidate details by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Candidate GetCandidateDetailsByEmail(string email);

        /// <summary>
        ///  add edit candidate
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        ResponseModel SaveCandidate(Candidate candidate);
    }
}

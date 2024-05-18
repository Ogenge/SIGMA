using Microsoft.EntityFrameworkCore;
using SIGMA.Models;

namespace SIGMA.Repository
{
    public class CandidateInterface : ICandidateInterface
    {
        private CandidateContext _candidateContext;

        public CandidateInterface(CandidateContext candidateContext)
        {
            _candidateContext = candidateContext;
        }

        public Candidate GetCandidateDetailsByEmail(string email)
        {
            Candidate candidate;
            try
            {
                candidate = _candidateContext.Candidate.Where(x => x.Email.Contains(email)).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            return candidate;
        }

        public ResponseModel SaveCandidate(Candidate candidate)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Candidate _temp = GetCandidateDetailsByEmail(candidate.Email);
                if (_temp != null)
                {
                    _temp.FirstName = candidate.FirstName;
                    _temp.LastName = candidate.LastName;
                    _temp.Email = candidate.Email;
                    _temp.PhoneNo = candidate.PhoneNo;
                    _temp.TimeToCall = candidate.TimeToCall;
                    _temp.LinkedIn = candidate.LinkedIn;
                    _temp.Github = candidate.Github;
                    _temp.FreeText = candidate.FreeText;

                    _candidateContext.Update<Candidate>(_temp);
                    model.Message = "Candidate Update Successfully";
                }
                else
                {
                    _candidateContext.Add<Candidate>(candidate);
                    model.Message = "Candidate Inserted Successfully";
                }
                _candidateContext.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Message = "Error : " + ex.Message;
            }
            return model;
        }
    }
}

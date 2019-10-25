using Assignment.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentSolution.Controllers
{
    public class AssignmentController : ApiController
    {
        private readonly IAssignmentService _assignmentService;
        public AssignmentController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }
            
        public HttpResponseMessage Get(string id)
        {
            int outcome = _assignmentService.CalculateScore(id);
            return Request.CreateResponse(HttpStatusCode.OK, outcome);

        }
    }
}

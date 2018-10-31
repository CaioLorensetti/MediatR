using MediatR;

namespace Sample.Domain.Requests
{
    public class TaskCreateRequest : IRequest<TaskCreateResponse>
    {
        public TaskCreateRequest()
        {
            
        }
    }
}
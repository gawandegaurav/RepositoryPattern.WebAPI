namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IDeveloperRepository DeveloperRepository { get; }
        IProjectRepository ProjectRepository { get; }

        int Complete();
    }
}
namespace WebApp2.DataAccessLayer.Interface
{
    public interface IUnitOfWork
    {
        IMemberRepository MemberRepository { get; set; }
        Task save(CancellationToken cancellationToken);
    }
}

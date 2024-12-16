﻿namespace sd_repo.Repositories.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        Task CommitAsync();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTracker.Data.Repositories
{
    public interface IUnitOfWork
    {
        IProjectsRepository ProjectsRepository { get; }

        void Save();
    }
}

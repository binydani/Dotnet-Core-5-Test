using Core.Entities;
using Core.Interfaces;
using System.Collections.Generic;
namespace Infrustructure.Data
{
    public class EFRepository<T>: IAsyncRepository<T> where T: BaseEntity
    {
    }
}

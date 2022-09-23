using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace treeApi.Tree
{
    public interface ITreeService
    {
        Task<TreeDto> GetTree();
    }
}

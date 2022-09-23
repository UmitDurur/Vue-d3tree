using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace treeApi.Tree
{
    public class TreeService : ApplicationService, ITreeService
    {
        public async Task<TreeDto> GetTree()
        {
            var tree = new TreeDto
            {
                Name = "root",
                Children = new List<TreeDto>()
            };
     
            for (int i = 0; i < 2; i++)
            {
                var child1 = new TreeDto
                {
                    Name = "child"+i,
                    Children = new List<TreeDto>()
                };
                for (int j = 0; j < 2; j++)
                {
                    var child2 = new TreeDto
                    {
                        Name = "child" + i+j,
                        Children = new List<TreeDto>()
                    };

                    child1.Children.Add(child2);
                }

                tree.Children.Add(child1);
            }

            return tree;
        }

    }
}

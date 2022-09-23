using System;
using System.Collections.Generic;
using System.Text;

namespace treeApi.Tree
{
    public class TreeDto
    {
        public List<TreeDto> Children { get; set; }

        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _13_02_23
{
	internal class Icourse
	{
		Group[] AddGroup(Group group);
		Group GetGroupByNo(string no);
		Group[] GetGroupsByPointRange(int minPoint, int maxPoint);
		Group[] Search(string str);
	}
}

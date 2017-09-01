using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Arrays_huge_struct_huge_struct_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_huge_struct_huge_struct_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\huge_struct\\huge_struct.cmd");
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _refany_array1_array1_
    {
        [OuterLoop]
        [Fact]
        public void _refany_array1_array1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\array1\\array1.cmd");
        }
    }
}

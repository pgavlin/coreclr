using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _Misc_Concat_ConcatTest_ConcatTest_
    {
        [OuterLoop]
        [Fact]
        public void _Misc_Concat_ConcatTest_ConcatTest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\Misc\\Concat\\ConcatTest\\ConcatTest.cmd");
        }
    }
}

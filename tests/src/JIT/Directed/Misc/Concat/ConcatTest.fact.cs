using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _Misc_Concat_ConcatTest_ConcatTest_
    {
        [OuterLoop]
        [Fact]
        public void _Misc_Concat_ConcatTest_ConcatTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\Misc\\Concat\\ConcatTest\\ConcatTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

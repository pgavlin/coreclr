using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__dbgunsafe_0__dbgunsafe_0_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__dbgunsafe_0__dbgunsafe_0_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_dbgunsafe-0\\_dbgunsafe-0.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

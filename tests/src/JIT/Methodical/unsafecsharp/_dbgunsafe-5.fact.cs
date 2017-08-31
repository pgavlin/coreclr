using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__dbgunsafe_5__dbgunsafe_5_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__dbgunsafe_5__dbgunsafe_5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_dbgunsafe-5\\_dbgunsafe-5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__dbgunsafe_3__dbgunsafe_3_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__dbgunsafe_3__dbgunsafe_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_dbgunsafe-3\\_dbgunsafe-3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

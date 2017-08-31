using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__dbgunsafe_6__dbgunsafe_6_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__dbgunsafe_6__dbgunsafe_6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_dbgunsafe-6\\_dbgunsafe-6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

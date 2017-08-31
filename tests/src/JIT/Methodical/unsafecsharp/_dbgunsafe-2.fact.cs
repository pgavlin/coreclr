using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__dbgunsafe_2__dbgunsafe_2_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__dbgunsafe_2__dbgunsafe_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_dbgunsafe-2\\_dbgunsafe-2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

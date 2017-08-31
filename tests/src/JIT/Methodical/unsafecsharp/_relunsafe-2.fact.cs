using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__relunsafe_2__relunsafe_2_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__relunsafe_2__relunsafe_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_relunsafe-2\\_relunsafe-2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

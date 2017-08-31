using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__relunsafe_6__relunsafe_6_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__relunsafe_6__relunsafe_6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_relunsafe-6\\_relunsafe-6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

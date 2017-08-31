using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _lifetime_lifetime1_lifetime1_
    {
        [OuterLoop]
        [Fact]
        public void _lifetime_lifetime1_lifetime1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\lifetime\\lifetime1\\lifetime1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

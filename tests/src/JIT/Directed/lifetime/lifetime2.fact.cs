using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _lifetime_lifetime2_lifetime2_
    {
        [OuterLoop]
        [Fact]
        public void _lifetime_lifetime2_lifetime2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\lifetime\\lifetime2\\lifetime2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _newarr_newarr_newarr_
    {
        [Fact]
        public void _newarr_newarr_newarr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\newarr\\newarr\\newarr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

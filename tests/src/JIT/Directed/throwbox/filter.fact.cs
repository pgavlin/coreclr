using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _throwbox_filter_filter_
    {
        [Fact]
        public void _throwbox_filter_filter_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\throwbox\\filter\\filter.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

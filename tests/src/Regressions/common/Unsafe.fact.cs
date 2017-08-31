using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _Unsafe_Unsafe_
    {
        [Fact]
        public void _Unsafe_Unsafe_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\Unsafe\\Unsafe.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

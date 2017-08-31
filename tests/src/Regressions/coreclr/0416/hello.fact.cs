using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0416_hello_hello_
    {
        [OuterLoop]
        [Fact]
        public void _0416_hello_hello_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0416\\hello\\hello.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_ddb3422_ddb3422_ddb3422_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_ddb3422_ddb3422_ddb3422_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\ddb3422\\ddb3422\\ddb3422.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

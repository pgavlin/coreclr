using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _1337_Test1337_Test1337_
    {
        [OuterLoop]
        [Fact]
        public void _1337_Test1337_Test1337_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\1337\\Test1337\\Test1337.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

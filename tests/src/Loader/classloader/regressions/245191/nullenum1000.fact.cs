using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_245191_nullenum1000_nullenum1000_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_245191_nullenum1000_nullenum1000_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\245191\\nullenum1000\\nullenum1000.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_208900_bug_bug_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_208900_bug_bug_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\208900\\bug\\bug.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

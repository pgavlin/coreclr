using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _1386_Co1727ctor_OO_Co1727ctor_OO_
    {
        [OuterLoop]
        [Fact]
        public void _1386_Co1727ctor_OO_Co1727ctor_OO_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\1386\\Co1727ctor_OO\\Co1727ctor_OO.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

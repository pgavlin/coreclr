using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _ArrayCopy_ArrayCopy_
    {
        [OuterLoop]
        [Fact]
        public void _ArrayCopy_ArrayCopy_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\ArrayCopy\\ArrayCopy.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace Regressions_expl_double
{
    class _expl_double_expl_double_
    {
        [OuterLoop]
        [Fact]
        public void _expl_double_expl_double_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\expl_double\\expl_double\\expl_double.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

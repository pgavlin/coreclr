using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__opt_relrefarg_s__opt_relrefarg_s_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__opt_relrefarg_s__opt_relrefarg_s_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_opt_relrefarg_s\\_opt_relrefarg_s.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

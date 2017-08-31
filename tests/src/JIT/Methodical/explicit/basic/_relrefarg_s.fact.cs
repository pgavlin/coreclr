using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__relrefarg_s__relrefarg_s_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__relrefarg_s__relrefarg_s_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_relrefarg_s\\_relrefarg_s.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

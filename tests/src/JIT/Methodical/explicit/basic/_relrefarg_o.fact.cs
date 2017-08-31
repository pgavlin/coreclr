using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__relrefarg_o__relrefarg_o_
    {
        [Fact]
        public void _explicit_basic__relrefarg_o__relrefarg_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_relrefarg_o\\_relrefarg_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

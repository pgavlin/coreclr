using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__rellcsvalbox__rellcsvalbox_
    {
        [Fact]
        public void _Arrays_lcs__rellcsvalbox__rellcsvalbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_rellcsvalbox\\_rellcsvalbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

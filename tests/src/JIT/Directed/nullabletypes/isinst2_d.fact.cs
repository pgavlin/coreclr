using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinst2_d_isinst2_d_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinst2_d_isinst2_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinst2_d\\isinst2_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

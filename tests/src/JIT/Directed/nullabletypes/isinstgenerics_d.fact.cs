using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstgenerics_d_isinstgenerics_d_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstgenerics_d_isinstgenerics_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstgenerics_d\\isinstgenerics_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

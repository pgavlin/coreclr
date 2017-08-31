using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstgenerics_r_isinstgenerics_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstgenerics_r_isinstgenerics_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstgenerics_r\\isinstgenerics_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
